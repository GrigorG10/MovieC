using MovieStore.BL;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MovieStore
{
    // Пример за клас A (трябва да дефинирате реалната му функционалност)
    class A
    {
        public int SomeProperty { get; set; }
    }

    // Пример за клас B (трябва да дефинирате реалната му функционалност)
    class B
    {
        public string AnotherProperty { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Инициализация на примерните класове
            var a = new A { SomeProperty = 42 };
            var b = new B { AnotherProperty = "Hello World" };

            // Регистриране на услуги в контейнера
            builder.Services
                .RegisterDataLayer()
                .RegisterBusinessLayer();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Конфигуриране на HTTP заявките
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

