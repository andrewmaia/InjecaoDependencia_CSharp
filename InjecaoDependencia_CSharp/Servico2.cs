namespace InjecaoDependencia_CSharp
{
    public interface IServico2
    {
        void Log();
    }
    public class Servico2 : IServico2
    {
        IServico1 _servico;
        public Servico2(IServico1 servico) => _servico = servico;

        public void Log()
        {
            _servico.Log();
        }
    }
}
