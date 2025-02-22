﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simu.App.Constantes
{
    public class Constantes
    {

        public static string questao11 = @"{
              'enunciado': 'Considere as premissas a seguir verdadeiras: Premissa 1: Se Daenerys come churrasco ou João anda a cavalo, então Cersei assiste a um filme.Premissa 2: Hoje, Cersei não assistiu a um filme. Premissa 3: Se hoje é domingo, então Daenerys come churrasco e Jaime treina esgrima. Premissa 4: Hoje, Jaime foi treinar esgrima. É correto concluir que:',
              'alternativas': [
               'Hoje é domingo e Daenerys comeu churrasco.',
               'Hoje não é domingo e Daenerys comeu churrasco.',
               'Hoje não é domingo e João não andou a cavalo.',
               'Daenerys comeu churrasco ou João andou a cavalo.',
               'Hoje é domingo e João andou a cavalo.'
                ],
               'resposta' : 'Hoje não é domingo e João não andou a cavalo.',
               'tipoAssunto' : 'Lógica Matemática',
               'anoProva': 2019
            }";
        public static string questao12 = @"{
              'enunciado': 'Considere a seguinte proposição: Em todos os cursos de Computação, existe, pelo menos, uma disciplina de Lógica. A negação da proposição acima é logicamente equivalente à proposição:',
              'alternativas': [
               'Em nenhum curso de Computação, há alguma disciplina de Lógica.',
               'Há, pelo menos, um curso de Computação no qual não há disciplina de Lógica.',
               'Em cada um dos cursos de Computação, não há disciplina de Lógica.',
               'Não há curso de Computação no qual tenha disciplina de Lógica.',
               'Há um curso de Computação no qual há, no máximo, uma disciplina de Lógica.'
                ],
               'resposta' : 'Há, pelo menos, um curso de Computação no qual não há disciplina de Lógica.',
               'tipoAssunto' : 'Lógica Matemática',
               'anoProva': 2019
            }";
        public static string questao13 = @"{
              'enunciado': 'Dez pessoas estão participando de um campeonato de xadrez. Na primeira rodada do campeonato, haverá cinco partidas. De quantas maneiras distintas é possível organizar a primeira rodada do campeonato, considerando que não há distinção entre a partida “competidor A versus competidor B” e a partida “competidor B versus competidor A”?',
              'alternativas': [
               45,
               252,
               945,
               3.840,
               113.400
                ],
               'resposta' :   945,
               'tipoAssunto' : 'Análise Combinatória',
               'anoProva': 2019
            }";
        public static string questao14 = @"{
              'enunciado': 'O número hexadecimal BEEF em base 2 é:',
              'alternativas': [
               '1010 1111 1111 1110',
               '1011 1110 1110 1111',
               '0010 0011 0011 0100',
               '1000 0101 0101 0100',
               '1001 1100 1100 1101'
                ],
               'resposta' : '1011 1110 1110 1111',
               'tipoAssunto' : 'Matemática Discreta',
               'anoProva': 2019
            }";
        public static string questao15 = @"{
              'enunciado': 'Uma pessoa deseja fazer uma compra na Internet e, para isso, precisa se cadastrar em um site. A senha de cadastro deve ser formada por exatamente 9 caracteres, e somente os caracteres $, @ e # podem ser usados. Quantas senhas diferentes, contendo pelo menos uma ocorrência de cada caractere, existem?',
              'alternativas': [
                    729,
                    4.374,
                    18.150,
                    61.236,
                    367.416
                ],
               'resposta' :  18.150,
               'tipoAssunto' : 'Análise Combinatória',
               'anoProva': 2019
            }";


    }
}
