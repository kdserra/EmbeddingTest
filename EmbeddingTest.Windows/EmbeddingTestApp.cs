using Stride.Engine;

namespace EmbeddingTest
{
    class EmbeddingTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
