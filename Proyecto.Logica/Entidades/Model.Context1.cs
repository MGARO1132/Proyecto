﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Proyecto.Logica.Entidades
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class bdGeneralEntities : DbContext
{
    public bdGeneralEntities()
        : base("name=bdGeneralEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<tbEstadoTareas> tbEstadoTareas { get; set; }

    public virtual DbSet<tbPosiblesClientes> tbPosiblesClientes { get; set; }

    public virtual DbSet<tbPrioridad> tbPrioridad { get; set; }

    public virtual DbSet<tbTareas> tbTareas { get; set; }

    public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }

    public virtual DbSet<tbEventos> tbEventos { get; set; }

    public virtual DbSet<tbRelacionadoCon> tbRelacionadoCon { get; set; }

}

}

