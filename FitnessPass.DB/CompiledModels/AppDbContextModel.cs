﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace FitnessPass.DB.CompiledModels
{
    [DbContext(typeof(AppDbContext))]
    public partial class AppDbContextModel : RuntimeModel
    {
        static AppDbContextModel()
        {
            var model = new AppDbContextModel();
            model.Initialize();
            model.Customize();
            _instance = model;
        }

        private static AppDbContextModel _instance;
        public static IModel Instance => _instance;

        partial void Initialize();

        partial void Customize();
    }
}
