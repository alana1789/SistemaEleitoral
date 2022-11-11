using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Eleitor eleitor = new Eleitor("64837", "Pedro G", 2);
        EleitorBLL eleitorBLL = new EleitorBLL();

        eleitorBLL.Inserir(eleitor);

    }
}