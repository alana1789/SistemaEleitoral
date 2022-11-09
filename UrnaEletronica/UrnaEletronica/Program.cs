using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Eleitor eleitor = new Eleitor("99999", "João", 2);
        EleitorBLL eleitorBLL = new EleitorBLL();

        eleitorBLL.Inserir(eleitor);
        
    }
}