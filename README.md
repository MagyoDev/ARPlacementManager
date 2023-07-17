# AR Placement Manager

O AR Placement Manager é um script desenvolvido em C# para Unity que permite colocar objetos de realidade aumentada (AR) em superfícies planas detectadas pelo dispositivo. Este script é adequado para aplicações de realidade aumentada que requerem a colocação precisa de objetos virtuais em um ambiente físico.

## Recursos

- Posiciona objetos AR em superfícies planas detectadas.
- Utiliza o ARRaycastManager do AR Foundation para raios AR.
- Fornecer feedback visual ao usuário com um objeto de marcação.

## Como usar

1. Clone ou faça o download deste repositório.
2. Adicione o script "PlacementManager.cs" ao objeto que deseja posicionar na cena de realidade aumentada.
3. Certifique-se de ter o AR Foundation configurado em sua cena.
4. Adicione um objeto de marcação visual (por exemplo, uma seta ou ponto) como filho do objeto associado ao script "PlacementManager.cs".
5. Ajuste a posição e rotação do objeto de marcação para o local desejado em relação ao objeto AR.
6. Execute o aplicativo em um dispositivo compatível com AR e aponte a câmera para um ambiente com superfícies planas.

## Notas

- Este script foi testado e projetado para funcionar com Unity e AR Foundation.
- Certifique-se de ter o pacote AR Foundation importado em sua Unity Package Manager.
