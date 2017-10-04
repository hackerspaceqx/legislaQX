using java.lang;
using java.util;
using org.hackerspaceqx.domain;

namespace org.hackerspaceqx.domain
{
	public class Proposicao
	{
		private Integer id;

		private String siglaUfAutor;

		private String siglaTipo;

		private String ementa;

		private String ementaDetalhada;

		private Integer idTipo;

		private String siglaPartidoAutor;

		private Integer numero;

		private Integer ano;

		private List<String> keywords;

		private String uriOrgaoNumerador;

		private String uriUltimoRelator;

		private Integer sequencia;

		private String siglaOrgao;

		private String uriOrgao;

		private String codOrgao;

		private String regime;

		private String descricaoTramitacao;

		private String idTipoTramitacao;

		private String descricaoSituacao;

		private String idSituacao;

		private String despacho;

		private String url;

		private Orgao orgao;

		private Tramitacao[] historicoDetramitacoes;

		private Date dataHora;

		private TipoProposicao tipoProposicao;

		private Votacao[] historicoDeVotacoes;

		private SituacaoProposicao situacaoProposicao;

		private Date dataApresentacao;

	}

}

