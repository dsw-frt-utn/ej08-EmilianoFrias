namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProductHelper helper = new ProductHelper();

            // 2. Definimos algunos datos de prueba para nuestro producto
            long testCode = 789456123;
            string testDescription = "Monitor Ultrawide 34 pulgadas";
            decimal testPrice = 450000.50m; // La 'm' al final es obligatoria en C# para indicar que el número es de tipo decimal

            // 3. Llamamos al método y guardamos el resultado en una variable
            string etiqueta = helper.ObtenerEtiquetaProducto(testCode, testDescription, testPrice);

            // 4. Imprimimos el resultado en la consola
            Console.WriteLine("--- Prueba de ProductHelper ---");
            Console.WriteLine(etiqueta);

            // Esta línea pausa la consola para que puedas ver el resultado hasta que presiones Enter
            Console.ReadLine();
        }
    }
}
