﻿using Bindito.Core;
using TimberApi.SpecificationSystem;
using UnityEngine;

namespace TimberApi.BuildingSpecificationSystem;

[Context("Game")]
internal class BuildingSpecificationConfigurator : IConfigurator
{
    public void Configure(IContainerDefinition containerDefinition)
    {
        containerDefinition.Bind<BuildingSpecificationService>().AsSingleton();
        containerDefinition.Bind<BuildingSpecificationObjectDeserializer>().AsSingleton();
        containerDefinition.Bind<BuildingCostObjectDeserializer>().AsSingleton();
        containerDefinition.MultiBind<ISpecificationGenerator>().To<BuildingSpecificationGenerator>().AsSingleton();
        containerDefinition.Bind<BuildingChangeApplier>().AsSingleton();
    }
}