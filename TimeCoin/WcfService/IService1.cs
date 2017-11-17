using System.ServiceModel;
using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        //TipoUsuario
        #region TipoUsuario
        [OperationContract]
        void TipoUsuarioInsert(TipoUsuario tipoUsuario);

        [OperationContract]
        void TipoUsuarioUpdate(TipoUsuario tipoUsuario);

        [OperationContract]
        void TipoUsuarioDelete(TipoUsuario tipoUsuario);

        [OperationContract]
        List<TipoUsuario> TipoUsuarioSelect(TipoUsuario filtro);

        [OperationContract]
        bool TipoUsuarioVerificaDuplicidade(TipoUsuario filtro);

        [OperationContract]
        bool TipoUsuarioVerificaExistencia(TipoUsuario filtro);
        #endregion

        //Situacao
        #region Situacao
        [OperationContract]
        void SituacaoInsert(Situacao situacao);

        [OperationContract]
        void SituacaoUpdate(Situacao situacao);

        [OperationContract]
        void SituacaoDelete(Situacao situacao);

        [OperationContract]
        List<Situacao> SituacaoSelect(Situacao filtro);

        [OperationContract]
        bool SituacaoVerificaDuplicidade(Situacao situacao);
        #endregion

        //Usuario
        #region Usuario
        [OperationContract]
        void UsuarioInsert(Usuario usuario);

        [OperationContract]
        void UsuarioUpdate(Usuario usuario);

        [OperationContract]
        void UsuarioDelete(Usuario usuario);

        [OperationContract]
        List<Usuario> UsuarioSelect(Usuario filtro);

        [OperationContract]
        bool UsuarioVerificaDuplicidade(Usuario usuario);
        #endregion

        //Servico
        #region Servico
        [OperationContract]
        void ServicoInsert(Servico servico);

        [OperationContract]
        void ServicoUpdate(Servico servico);

        [OperationContract]
        void ServicoDelete(Servico servico);

        [OperationContract]
        List<Servico> ServicoSelect(Servico filtro);

        [OperationContract]
        bool ServicoVerificaDuplicidade(Servico servico);
        #endregion

        //Habilidade
        #region Habilidade
        [OperationContract]
        void HabilidadeInsert(Habilidade habilidade);

        [OperationContract]
        void HabilidadeUpdate(Habilidade habilidade);

        [OperationContract]
        void HabilidadeDelete(Habilidade habilidade);

        [OperationContract]
        List<Habilidade> HabilidadeSelect(Habilidade habilidade);

        [OperationContract]
        bool HabilidadeVerificaDuplicidade(Habilidade habilidade);
        #endregion

        //Presta
        #region Presta
        [OperationContract]
        void PrestaInsert(Presta presta);        

        [OperationContract]
        void PrestaDelete(Presta presta);

        [OperationContract]
        List<Presta> PrestaSelect(Presta presta);        
        #endregion

        //Recebe
        #region Recebe
        [OperationContract]
        void RecebeInsert(Recebe recebe);        

        [OperationContract]
        void RecebeDelete(Recebe recebe);

        [OperationContract]
        List<Recebe> RecebeSelect(Recebe recebe);        
        #endregion

        //Anuncio
        #region Anuncio
        [OperationContract]
        void AnuncioInsert(Anuncio anuncio);

        [OperationContract]
        void AnuncioUpdate(Anuncio anuncio);

        [OperationContract]
        void AnuncioDelete(Anuncio anuncio);

        [OperationContract]
        List<Anuncio> AnuncioSelect();

        [OperationContract]
        bool AnuncioVerificaDuplicidade(Anuncio anuncio);
        #endregion 

        //TipoAnuncio
        #region TipoAnuncio
        [OperationContract]
        void TipoAnuncioInsert(TipoAnuncio tipoAnuncio);

        [OperationContract]
        void TipoAnuncioUpdate(TipoAnuncio tipoAnuncio);

        [OperationContract]
        void TipoAnuncioDelete(TipoAnuncio tipoAnuncio);

        [OperationContract]
        List<TipoAnuncio> TipoAnuncioSelect();

        [OperationContract]
        bool TipoAnuncioVerificaDuplicidade(TipoAnuncio tipoAnuncio);
        #endregion 

        //UsuarioHabilidade
        #region UsuarioHabilidade
        [OperationContract]
        void UsuarioHabilidadeInsert(UsuarioHabilidade usuarioHabilidade);

        [OperationContract]
        void UsuarioHabilidadeUpdate(UsuarioHabilidade usuarioHabilidade);

        [OperationContract]
        void UsuarioHabilidadeDelete(UsuarioHabilidade usuarioHabilidade);

        [OperationContract]
        List<UsuarioHabilidade> UsuarioHabilidadeSelect();

        [OperationContract]
        bool UsuarioHabilidadeVerificaDuplicidade(UsuarioHabilidade usuarioHabilidade);
        #endregion 
    }
}
