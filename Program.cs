using metodos_construtores.Models;

Pessoa p1 = new Pessoa("Leonardo", "Buta");
p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Lucas", sobrenome:"Nascimento"); //podemos mostrar o nome do parametro para facilitar a leitura



Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
