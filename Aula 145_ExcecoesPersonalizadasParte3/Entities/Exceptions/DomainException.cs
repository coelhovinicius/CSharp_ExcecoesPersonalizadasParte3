/* >>> CLASSE DOMAINEXCEPTION - Classe Personalizada para tratar as Excecoes <<< */
using System;

namespace Aula_145_ExcecoesPersonalizadasParte3.Entities.Exceptions
{
    class DomainException : ApplicationException // Excecao de Dominio
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
