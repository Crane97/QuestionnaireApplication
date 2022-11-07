﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestionnaireApplication.repositories;

#nullable disable

namespace QuestionnaireApplication.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20221107151333_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuestionnaireApplication.models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Option")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("answer");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("question");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.UserAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionIdId")
                        .HasColumnType("int");

                    b.Property<int>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionIdId");

                    b.HasIndex("UserIdId");

                    b.ToTable("useranswer");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.Answer", b =>
                {
                    b.HasOne("QuestionnaireApplication.models.Question", null)
                        .WithMany("AnswerText")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.UserAnswer", b =>
                {
                    b.HasOne("QuestionnaireApplication.models.Question", "QuestionId")
                        .WithMany()
                        .HasForeignKey("QuestionIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestionnaireApplication.models.User", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("QuestionnaireApplication.models.Question", b =>
                {
                    b.Navigation("AnswerText");
                });
#pragma warning restore 612, 618
        }
    }
}
