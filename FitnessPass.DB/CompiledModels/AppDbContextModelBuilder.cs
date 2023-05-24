﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace FitnessPass.DB.CompiledModels
{
    public partial class AppDbContextModel
    {
        partial void Initialize()
        {
            var client = ClientEntityType.Create(this);
            var clientPass = ClientPassEntityType.Create(this);
            var entries = EntriesEntityType.Create(this);
            var gym = GymEntityType.Create(this);
            var user = UserEntityType.Create(this);
            var passType = PassTypeEntityType.Create(this);

            ClientPassEntityType.CreateForeignKey1(clientPass, client);
            ClientPassEntityType.CreateForeignKey2(clientPass, passType);
            EntriesEntityType.CreateForeignKey1(entries, client);
            EntriesEntityType.CreateForeignKey2(entries, passType);
            PassTypeEntityType.CreateForeignKey1(passType, gym);

            ClientEntityType.CreateAnnotations(client);
            ClientPassEntityType.CreateAnnotations(clientPass);
            EntriesEntityType.CreateAnnotations(entries);
            GymEntityType.CreateAnnotations(gym);
            UserEntityType.CreateAnnotations(user);
            PassTypeEntityType.CreateAnnotations(passType);

            AddAnnotation("ProductVersion", "7.0.5");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
