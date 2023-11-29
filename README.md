# Automa��o para reescalar os objetivos de otimiza��o do planejamento

### Descri��o

Aplica��o do tipo _"Plug-in Binary"_ que reescala os objetivos de otimiza��o do planejamento selecionado no TPS _"**Eclipse**"_ para um novo fracionamento de dose.

#

### Temas abordados

-   Desenvolvimento de interface do usu�rio com diferentes elementos usando _[WPF]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/introduction-to-wpf?view=netframeworkdesktop-4.8)_
-   Cria��o da apar�ncia em _[XAML]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/advanced/xaml-in-wpf?view=netframeworkdesktop-4.8)_
-   Adi��o de elementos na interface gr�fica em tempo de execu��o e cria��o das opera��es l�gicas usando _[Code-Behind]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/advanced/code-behind-and-xaml-in-wpf?view=netframeworkdesktop-4.8)_
-   Manipula��o das classes e funcionalidades da **API**, especialmente com aquelas relacionadas aos objetivos de otimiza��o do planejamento

#

### Passo-a-passo da implementa��o da aplica��o

1. Adicionando a interface gr�fica do usu�rio
  
    Cria��o do layout da interface gr�fica do usu�rio. Para isso vamos adicionar um _[UserControl](  https://learn.microsoft.com/pt-br/dotnet/api/system.windows.controls.usercontrol?view=netframework-4.5)_  ao projeto e incorporar diferentes elementos de controle. Em seguida, vamos conectar a interface � classe inicial do projeto.
     
###

2. Preenchendo os campos da interface gr�fica os com dados do fracionamento atual
    
    Cria��o de um m�todo para obter os valores de dose por fra��o e n�mero de fra��o do planejamento atual e preencher os respectivos campos da interface do usu�rio.

###

3. Preenchendo a interface com os nomes das estruturas que possuem objetivos de otimiza��o
    
     Cria��o de um m�todo para preencher a interface do usu�rio com as estruturas que possuem objetivos de otimiza��o.    

###
4. Gerando o manipulador de evento dos campos do novo fracionamento

    Desenvolvimento da l�gica do evento de preenchimento dos campos relacionados ao novo fracionamento realizado pelo usu�rio.
    
###
5. Implementando o manipulador de evento do bot�o iniciar

     L�gica para duplicar o planejamento selecionado no contexto do Eclipse e atribuir a essa c�pia os objetivos de otimiza��o reescalados para o novo fracionamento de dose.

##
### Orienta��es Finais

- [Download do Visual Studio Community 2019](https://visualstudio.microsoft.com/pt-br/vs/older-downloads/)

| Vers�o do Eclipse | Vers�o do .NET Framework |
| ------ | ------ |
| V16+| V 4.6.1 |
| V15.6 ou V15.5 | V 4.5 |
