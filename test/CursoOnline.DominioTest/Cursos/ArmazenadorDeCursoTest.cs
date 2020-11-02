using System.Linq.Expressions;
using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.Enumerators;
using Moq;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        [Fact]
        public void DeveAdicionarCurso()
        {
            var cursoDto = new CursoDto
            {
                Nome = "Curso A",
                Descricao = "Descrição",
                CargaHoraria = 80,
                PublicoAlvo = 1,
                Valor = 850.00,
            };

            var cursoRepositorioMock = new Mock<ICursoRepository>();

            var armazenadorDeCurso = new ArmazenadorDeCurso(cursoRepositorioMock.Object);

            armazenadorDeCurso.Armazenar(cursoDto);
            cursoRepositorioMock.Verify(r => r.Adicionar(It.IsAny<Curso>()));
        }
    }

    public interface ICursoRepository
    {
        void Adicionar(Curso curso);
    }

    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepository _cursoRepository;

        public ArmazenadorDeCurso(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public void Armazenar(CursoDto cursoDto)
        {
            var curso = new Curso(cursoDto.Nome, cursoDto.Descricao, cursoDto.CargaHoraria, 
                PublicoAlvo.Estudante, cursoDto.Valor);

           _cursoRepository.Adicionar(curso);
        }
    }

    public class CursoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public int PublicoAlvo { get; set; }
        public double Valor { get; set; }
    }
}
