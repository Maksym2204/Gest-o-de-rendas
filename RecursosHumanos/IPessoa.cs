namespace RecursosHumanos
{
    /// <summary>
    /// Interface que define as propriedades básicas de uma pessoa.
    /// </summary>
    public interface IPessoa
    {
        /// <summary>
        /// Obtém ou define o NIF (Número de Identificação Fiscal) da pessoa.
        /// </summary>
        string NIF { get; set; }

        /// <summary>
        /// Obtém ou define o nome da pessoa.
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o número de telefone da pessoa.
        /// </summary>
        string Telefone { get; set; }

        /// <summary>
        /// Obtém ou define o endereço de e-mail da pessoa.
        /// </summary>
        string Email { get; set; }
    }
}
