﻿using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
    public class EntityBehaviour : MonoBehaviour, IEntityView
    {
        private GameEntity _entity;
        private ICollisionRegistry _collisionRegistry;

        public GameEntity Entity => _entity;
        public GameObject GameObject { get; }

        [Inject]
        private void Construct(ICollisionRegistry collisionRegistry) => 
            _collisionRegistry = collisionRegistry;

        public void SetEntity(GameEntity entity)
        {
            _entity = entity;
            _entity.AddView(this);
            _entity.Retain(this);

            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.RegisterComponents();

            foreach (Collider2D collider in GetComponentsInChildren<Collider2D>(true)) 
                _collisionRegistry.Register(collider.GetInstanceID(),_entity);
        }

        public void ReleaseEntity()
        {
            foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
                registrar.UnRegisterComponents();
            
            foreach (Collider2D collider in GetComponentsInChildren<Collider2D>(true)) 
                _collisionRegistry.Unregister(collider.GetInstanceID());
            
            _entity.Release(this);
            _entity = null;
        }

    }
}