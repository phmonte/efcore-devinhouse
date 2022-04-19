namespace EfCoreCodeFirst.Modelos;

public class Proprietario
{
    public int Id { get; set; }   
    public string Nome { get; set; }   
    public ICollection<Contato> Contatos { get; set; }   
}