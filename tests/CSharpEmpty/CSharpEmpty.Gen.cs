using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Utils;

namespace CppSharp.Tests
{
    public class CSharpEmptyTestsGenerator : GeneratorTest
    {
        public CSharpEmptyTestsGenerator(GeneratorKind kind)
            : base("CSharpEmpty", kind)
        {
        }

        public override void Setup(Driver driver)
        {
            base.Setup(driver);
        }

        public override void SetupPasses(Driver driver)
        {
        }

        public override void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public static void Main(string[] args)
        {
            ConsoleDriver.Run(new CSharpEmptyTestsGenerator(GeneratorKind.CSharp));
        }
    }
}
