namespace RecursosHumanos
{
    /// <summary>
    /// Interface que define operações relacionadas a saldo.
    /// </summary>
    public interface ISaldo
    {
        /// <summary>
        /// Retira um valor do saldo.
        /// </summary>
        /// <param name="valor">O valor a ser retirado.</param>
        /// <returns>O novo saldo após a retirada.</returns>
        void RetirarSaldo(double valor);
    }
}
