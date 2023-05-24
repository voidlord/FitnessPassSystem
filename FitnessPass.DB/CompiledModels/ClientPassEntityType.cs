﻿// <auto-generated />
using System;
using System.Reflection;
using FitnessPass.Model;
using FitnessPassApp.Data;
using Microsoft.EntityFrameworkCore;
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

            var passTypeId = runtimeEntityType.AddProperty(
                "PassTypeId",
                typeof(int),
                propertyInfo: typeof(ClientPass).GetProperty("PassTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<PassTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            passTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

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

            var index = runtimeEntityType.AddIndex(
                new[] { clientId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { passTypeId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ClientId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ClientId")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var client = declaringEntityType.AddNavigation("Client",
                runtimeForeignKey,
                onDependent: true,
                typeof(Client),
                propertyInfo: typeof(ClientPass).GetProperty("Client", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<Client>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PassTypeId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PassId")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var passType = declaringEntityType.AddNavigation("PassType",
                runtimeForeignKey,
                onDependent: true,
                typeof(PassType),
                propertyInfo: typeof(ClientPass).GetProperty("PassType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ClientPass).GetField("<PassType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
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
