using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Classes.Endereco;
using Classes.Onibus;

namespace Classes.Transporte
{

	public class Empresa
	{
		private String Nome;

		private String CNPJ;

		private String Usuario;

		private String Senha;

		private String Numeral;

		private Coletivo onibus;

		private Paradas paradas;

		private Endereço endereço;

		private Linhas linhas;

		private ICollection<Reclamacao> reclamacao;

		private Linhas Linhas;

		///  
		public void Incluir_Empresa()
		{

		}

		///  
		public void Remover_Empresa()
		{

		}

		///  
		public void Alterar_Empresa()
		{

		}

		///  
		public void Buscar_Empresa()
		{

		}

		public String Valida_CNPJ()
		{
			return null;
		}

		public String Valida_IE()
		{
			return null;
		}

	}

}