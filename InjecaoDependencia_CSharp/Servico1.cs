namespace InjecaoDependencia_CSharp
{
    public interface IServico1
    {
        void Log();
    }

    public class Servico1 : IServico1
    {
        public void Log()
        {
            Console.WriteLine("Log");
        }
    }
}
