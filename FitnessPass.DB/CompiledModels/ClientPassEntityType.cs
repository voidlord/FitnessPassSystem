﻿// <auto-generated />
using System;
using System.Reflection;
using FitnessPass.Model;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace FitnessPass.DB.CompiledModels
{
    internal partial class ClientPassEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "FitnessPass.Model.ClientPass",
                typeof(ClientPass),
                baseEntityType);

            var clientPassId = runtimeEntityType.AddProperty(
                "ClientPassId",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("ClientPassId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<ClientPassId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            clientPassId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var barCode = runtimeEntityType.AddProperty(
                "BarCode",
                typeof(string),
                propertyInfo: typeof(ClientPass).GetProperty("BarCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<BarCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            barCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var clientId = runtimeEntityType.AddProperty(
                "ClientId",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("ClientId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<ClientId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            clientId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdOn = runtimeEntityType.AddProperty(
                "CreatedOn",
                typeof(DateTime),
                propertyInfo: typeof(ClientPass).GetProperty("CreatedOn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<CreatedOn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            createdOn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var entryCount = runtimeEntityType.AddProperty(
                "EntryCount",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("EntryCount", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<EntryCount>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            entryCount.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var firstUsedOn = runtimeEntityType.AddProperty(
                "FirstUsedOn",
                typeof(DateTime),
                propertyInfo: typeof(ClientPass).GetProperty("FirstUsedOn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<FirstUsedOn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            firstUsedOn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var gymId = runtimeEntityType.AddProperty(
                "GymId",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("GymId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<GymId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            gymId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passId = runtimeEntityType.AddProperty(
                "PassId",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("PassId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<PassId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            passId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var salePrice = runtimeEntityType.AddProperty(
                "SalePrice",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("SalePrice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<SalePrice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            salePrice.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valid = runtimeEntityType.AddProperty(
                "Valid",
                typeof(bool),
                propertyInfo: typeof(ClientPass).GetProperty("Valid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<Valid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            valid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { clientPassId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ClientPass");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}