using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PPODCOPAS.Models
{

    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Derechos Humanos"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Deberes Humanos"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Polihumanismo"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Introducción a los Derechos Humanos",
                    Description = "Este curso ofrece una visión general de los derechos humanos, sus orígenes históricos y los principios fundamentales que guían la protección de la dignidad humana en el mundo moderno.",
                    ImagePath="Cake.png",
                    UnitPrice = 16900,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Derechos Humanos y Políticas Públicas",
                    Description = "Explora cómo las políticas públicas a nivel local, nacional e internacional pueden promover o vulnerar los derechos humanos, y cómo se puede influir en la legislación para fortalecer su protección.",
                    ImagePath="Parfait.png",
                    UnitPrice = 8300,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Mujeres y Derechos Humanos: Igualdad de Género",
                    Description = "Un curso que aborda los derechos específicos de las mujeres, el feminismo y las luchas históricas por la igualdad de género, además de analizar los desafíos actuales y las soluciones para promover la equidad.",
                    ImagePath="profiteroles.png",
                    UnitPrice = 2000,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Derechos Humanos en el Trabajo",
                    Description = "Este curso cubre los derechos laborales fundamentales, como la igualdad de oportunidades, la prohibición del trabajo infantil, el acoso laboral y la lucha por condiciones dignas en el lugar de trabajo.",
                    ImagePath="tarta.png",
                    UnitPrice = 40000,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 5,
                    ProductName = "Protección de los Derechos Humanos en Contextos de Conflicto",
                    Description = "Aprende sobre la protección de los derechos humanos en zonas de conflicto, el derecho internacional humanitario y el papel de los organismos internacionales en la mediación de la paz.",
                    ImagePath="Pastel rosa.png",
                    UnitPrice = 50000,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Derechos de los Pueblos Indígenas",
                    Description = "Un curso diseñado para profundizar en los derechos de los pueblos indígenas, sus luchas por la autonomía, la preservación de sus culturas y el acceso a la tierra, y cómo las leyes internacionales los protegen.",
                    ImagePath="Pastel de queso.png",
                    UnitPrice = 50000,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Derechos Humanos y Medio Ambiente",
                    Description = "Explora la intersección entre derechos humanos y medio ambiente, y cómo la degradación ambiental afecta de manera desproporcionada a las comunidades más vulnerables.",
                    ImagePath="Pastel de chocolate.png",
                    UnitPrice = 50000,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Niñez y Derechos Humanos",
                    Description = "Este curso aborda los derechos fundamentales de la niñez, las leyes que protegen a los menores de edad y cómo la educación y las políticas públicas pueden asegurar un mejor futuro para ellos.",
                    ImagePath="Pastel de frutas.png",
                    UnitPrice = 50000,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Derechos Humanos y Tecnologías Digitales",
                    Description = "Analiza el impacto de la tecnología en los derechos humanos, cubriendo temas como la privacidad digital, la libertad de expresión en línea, y el uso ético de la inteligencia artificial.",
                    ImagePath="Galletas Macarons.png",
                    UnitPrice = 2700,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Derechos de las Personas con Discapacidad",
                    Description = "Conoce las leyes y políticas que protegen los derechos de las personas con discapacidad, y las mejores prácticas para garantizar su inclusión social y accesibilidad en todos los entornos.",
                    ImagePath="Galleta estrella.png",
                    UnitPrice = 3000,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Derechos Humanos y Migración",
                    Description = "Un curso que examina los derechos de los migrantes, refugiados y solicitantes de asilo, las condiciones que generan desplazamientos forzados, y las obligaciones de los Estados para protegerlos.",
                    ImagePath="Pretzels.png",
                    UnitPrice = 8000,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Mecanismos Internacionales para la Defensa de los Derechos Humanos",
                    Description = "Aprende sobre los organismos internacionales que velan por los derechos humanos, como las Naciones Unidas, la Corte Interamericana de Derechos Humanos, y el rol de las ONGs en la protección global.",
                    ImagePath="Galletas de jengibre.png",
                    UnitPrice = 5000,
                    CategoryID = 3
                },
            };

            return products;
        }
    }
}