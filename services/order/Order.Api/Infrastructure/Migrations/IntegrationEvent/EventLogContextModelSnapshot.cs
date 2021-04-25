﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Zero.Eventlog;

namespace Order.Api.Infrastructure.Migrations.IntegrationEvent
{
    [DbContext(typeof(EventLogContext))]
    partial class EventLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Zero.Eventlog.EventLogEntry", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("eventid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("creationtime");

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("eventtypename");

                    b.Property<int>("State")
                        .HasColumnType("integer")
                        .HasColumnName("state");

                    b.Property<int>("TimesSent")
                        .HasColumnType("integer")
                        .HasColumnName("timessent");

                    b.HasKey("EventId")
                        .HasName("pk_integrationeventlogs");

                    b.ToTable("integrationeventlogs");
                });
#pragma warning restore 612, 618
        }
    }
}
