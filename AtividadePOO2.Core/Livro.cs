namespace AtividadePOO2.Core;

public class Livro
{
    public Livro( int paginas, int preco, string titulo, string autor, string genero, DateTime datalivro)
    {
        Validartitulo(titulo);
        Validarpaginas(paginas);
        Validarpreco(preco);
        ValidarAutor(autor);
        ValidarGenero(genero);
        ValidarDataLivro(datalivro);
    }

    private void ValidarGenero(string? genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("O género do livro não pode ser nulo ou vazio!");

        if (genero.Length < 3)
            throw new Exception("O género do livro precisa ter pelo menos 3 caracteres!");
    }

    private void ValidarAutor(string? autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("O autor do livro não pode ser nulo ou vazio!");

        if (autor.Length < 3)
            throw new Exception("O nome do autor precisa ter pelo menos 3 caracteres!");
    }
    

private void ValidarDataLivro(DateTime dataLivro)
    {
        {
            if (dataLivro == default)
                throw new Exception("A data do livro não pode ser vazia!");

            if (dataLivro > DateTime.Today)
                throw new Exception("A data do livro não pode ser futura!");
        }
    }

    private void Validarpreco(int preco)
    {
        if (preco <= 0)
            throw new Exception("O preço do livro deve ser maior que zero!");
    }

    private void Validarpaginas(int paginas)
    {
        if (paginas <= 0)
            throw new Exception("O número de páginas deve ser maior que zero!");
    }
    

    private void Validartitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("O título do livro não pode ser nulo ou vazio!");

        if (titulo.Length < 3)
            throw new Exception("O título do livro precisa ter pelo menos 3 caracteres!");
    }


    public int Id { get; set; }
    public DateTime DataLivro { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int Paginas { get; set; }
    public int Preco { get; set; }
}


