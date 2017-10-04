using java.lang;
using java.util;
using org.hackerspaceqx.domain;

namespace org.hackerspaceqx.domain
{
	public class Deputado
	{
		private Integer id;

		private String uri;

		private String nomeCivil;

		private String cpf;

		private String sexo;

		private String urlWebsite;

		private String redeSocial;

		private String ufNascimento;

		private String municipioNascimento;

		private String escolaridade;

		private Date dataFalecimento;

		private PapelEmOrgao[] papelEmOrgaos;

		private SituacaoDeputado situacaoDeputado;

		private Despesa[] despesas;

		private UltimoStatusDeputado ultimoStatusDeputado;

		private Legislatura[] legislaturas;

		private Date dataNascimento;

		private Evento[] eventosParticipados;

		private Mesa[] participacaoEmMesa;

	}

}

