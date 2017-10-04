using java.lang;
using org.hackerspaceqx.domain;
using java.util;

namespace org.hackerspaceqx.domain
{
	public class Evento
	{
		private Integer id;

		private String descricaoSituacao;

		private String descricaoTipo;

		private String localCamara;

		private String localExterno;

		private SituacaoEvento situacaoEvento;

		private Date dataHoraFim;

		private TipoEvento evento;

		private LocalCamara localDetalhadoCamara;

		private Date dataHoraInicio;

	}

}

