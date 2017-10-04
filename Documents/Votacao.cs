using java.lang;
using org.hackerspaceqx.domain;

namespace org.hackerspaceqx.domain
{
	public class Votacao
	{
		private Integer id;

		private Integer idProposicao;

		private String uri;

		private String titulo;

		private String uriEvento;

		private String tipoVotacao;

		private Boolean aprovada;

		private Integer placarSim;

		private Integer placarNao;

		private Integer placarAbstencao;

		private Proposicao proposicao;

	}

}

