using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Livros
    {
        private List<Livro> acervo;

        public List<Livro> Acervo { get { return this.acervo; } }

        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        public void adicionar(Livro a)
        {
            this.acervo.Add(a);
            //            if (this.pesquisar(livro) != null) throw new Exception("Já existe um livro com esse ISBN.");
            //this.acervo.Add(livro);
        }

        public Livro pesquisar(Livro a)
        {
            // return this.acervo.FirstOrDefault(item => item.Equals(livro));

            // professor -----------------------------
            // desenvolver a logica para buscar um livro no Acervo( List<Livro>)
            // Livro livroAchado =new Liveo();
            //foreach (Livro livro1 in this.acervo)
            //{
            //    if (livro1.Isbn.Equals(a.isbn))
            //        livroAchado = livro1;
            //}
            //return livroAchado;

            return this.acervo.FirstOrDefault(item => item.Equals(a));

        }

    }// fim class
}
