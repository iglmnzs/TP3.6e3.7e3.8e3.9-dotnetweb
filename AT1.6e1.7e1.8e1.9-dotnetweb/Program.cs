namespace AT1._6e1._7e1._8e1._9_dotnetweb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*QUESTÕES 6, 7, 8 e 9 - AT*/

            /*
            QUESTÃO 6 - Como o EF Core usa convenções para criar o modelo de dados a partir das classes C#? 
            
            RESPOSTA - 

            O EF Core gera as tabelas de acordo com as classes C#, sendo as colunas equivalentes aos nomes das propriedades
            da classe. Ou seja, uma classe Professor, seria uma tabela Professor com  as colunas Id, Nome e Cpf. Esse mapeamento
            gera um modelo de banco de dados sem a necessidade de configurações explícitas e, automaticamente, os relacionamentos
            e chaves são gerados.

           -------------------------------------------------------------------------------------------------------------------------  

            QUESTÃO 7 - O que são migrações em EF Core e como elas facilitam a evolução do esquema de banco de dados ao longo do tempo?
            
            RESPOSTA - 
            
            A "migrations" é um tipo de funcionalidade que gerencia alterações no banco de dados e oferece uma forma de 
            atualizar esse mesmo banco. Facilita o desenvolvedor pois atualiza de forma incremental, mantendo todo o modelo de dados
            atualizados na medida em que o sistema é mantido. É extramamente útil, pois todo o processo é feito automaticamente
            por usos de comandos simples.


            ----------------------------------------------------------------------------------------------------------------------

            QUESTÃO 8 - Qual é a diferença entre carregamento adiantado (eager loading) e carregamento lento (lazy loading) em EF Core?

            RESPOSTA - 

            Carregamento adiantado (eager loading) ->  Eager Load é um recurso que carrega antecipadamente todas as entidades relacionadas 
            em uma única consulta ao banco de dados. Esta estratégia visa reduzir as requisicoes ao banco de dados, 
            buscando antecipadamente os dados necessários em conjunto com a principal entidade.
             
            Carregamento lento (lazy loading) -> Lazy Loading é uma funcionalidade que permite que as entidades relacioandas sejam
            carregadas somente quando são acessadas pela aplicação de forma explícita.

            ------------------------------------------------------------------------------------------------------------------------

            QUESTÃO 9 - Explique a importância das Data Annotations no EF Core e como elas podem ser usadas para configurar 
            o modelo de dados.

            RESPOSTA - 

            Os Data Annotations são atributos que podem ser utilizados em classes ou também em suas propriedades para que se
            estabeleça o tipo de comportamento que será mapeado entre as classes e modelagem do banco de dados. É feito somente
            através de uma declaração simples, propondo ganho de produtividade para o desenvolvedor, podendo, também, 
            configurar e validar os dados de forma muito simples. Dentre algumas notações: [Key], [Required], [ForeignKey], 
            [StringLength].


             
             */
        }
    }
}
