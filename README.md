# Avalonia LibVLCSharp Audio Player

Este é um exemplo de aplicativo que utiliza a biblioteca Avalonia para a interface gráfica e a LibVLCSharp para reprodução de áudio. O aplicativo apresenta um visualizador gráfico simples com um retângulo preenchido com a imagem de um gato que se move na tela em resposta às teclas W, A, S e D ou pelas teclas de setas, enquanto reproduz um efeito sonoro correspondente.

## Funcionalidades

- **Movimento do Retângulo (Gato):** O gato pode ser movido para cima (W ou Seta para Cima), para baixo (S ou Seta para Baixo), para a esquerda (A ou Seta para Esquerda) e para a direita (D ou Seta para Direita).
- **Reprodução de Áudio:** Um efeito sonoro é reproduzido conforme o gato se move.

## Estrutura do Código

- **Player Class:**

  - **Image:** Propriedade que armazena a imagem do jogador.
  - **Player(bitmap1):** Construtor que inicializa a propriedade de imagem com base em um bitmap fornecido.

- **SoundFx Class (Herda de LibVLC):**

  - **File:** Caminho do arquivo de áudio.
  - **Media:** Objeto de mídia.
  - **MediaPlayer:** Reprodutor de mídia.
  - **SoundFx(file):** Construtor que inicializa o arquivo de áudio, a mídia e o reprodutor de mídia.

- **MainView Class (Avalonia Window):**
  - **Rect_OnKeyDown:** Manipula eventos de teclado para mover o retângulo (gato) e reproduzir o efeito sonoro.
  - **Rect_RequestFocus:** Define o foco no retângulo e atribui a imagem do jogador a ele.

## LibVLCSharp

A biblioteca LibVLCSharp é essencial para a reprodução de áudio. Certifique-se de instalar o SDK do .NET Core e a biblioteca libvlc no sistema antes de executar o aplicativo. Para informações detalhadas sobre a instalação da LibVLCSharp no Linux, consulte [este guia](https://github.com/videolan/libvlcsharp/blob/3.x/docs/linux-setup.md).

### Pré-requisitos

- Instale o SDK do .NET Core.
- Instale a biblioteca libvlc no sistema. No Ubuntu, você pode usar o seguinte comando:

  ```bash
  sudo apt install libvlc-dev
  ```

Certifique-se de que as bibliotecas libvlc.so e libvlccore.so estão localizadas em /usr/lib. Caso contrário, ajuste a variável LD_LIBRARY_PATH.

Você também pode precisar instalar o VLC:

```bash
  sudo apt install vlc
```

## Instruções de Uso

1. Instale o .NET Core SDK.
2. Instale a biblioteca libvlc no sistema.
3. Execute o aplicativo com o comando:

```bash
dotnet run
```

4. Use as teclas W, A, S e D para movimentar o retângulo (gato) na tela.
5. Observe a reprodução do efeito sonoro conforme o retângulo se move.
