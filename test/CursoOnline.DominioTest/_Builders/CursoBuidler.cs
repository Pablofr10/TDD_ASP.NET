using CursoOnline.DominioTest.Cursos;

namespace CursoOnline.DominioTest._Builders
{
    public class CursoBuidler
    {
        private string _nome = "Informática Básica";
        private double _cargaHoraria = 80;
        private PublicoAlvo _publicoAlvo = PublicoAlvo.Estudante;
        private double _valor = 90;
        private string _descricao = "descrição";
        public static CursoBuidler Novo()
        {
            return new CursoBuidler();
        }

        public CursoBuidler ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public CursoBuidler ComDescricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }
        public CursoBuidler ComCargaHoraria(double comCargaHoraria)
        {
            _cargaHoraria = comCargaHoraria;
            return this;
        }
        public CursoBuidler ComValor(double valor)
        {
            _valor = valor;
            return this;
        }
        public CursoBuidler ComPublicoAlvo(PublicoAlvo comPublicoAlvo)
        {
            _publicoAlvo = comPublicoAlvo;
            return this;
        }

        public Curso Build()
        {
            return new Curso(_nome, _descricao, _cargaHoraria, _publicoAlvo, _valor);
        }
    }
}
