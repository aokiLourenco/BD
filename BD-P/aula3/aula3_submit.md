# BD: Guião 3


## ​Problema 3.1
 
### *a)*

```
Cliente{
    NIF:Integer
    nome:String
    endereço:String
    num_carta:Integer
}

Aluger{
    número:Integer
    duração:Integer
    data:Integer
}

Balcão{
    número:Integer
    endereço:String
    nome:String
}

Veículo{
    matrícula:Integer
    ano:Integer
    marca:String
}

Tipo_Veículo{
    código:Integer
    arcondicionado:Boolean
    designação:String
}

Ligeiro{
    numLugares:Integer
    portas:Integer
    combustível:String
}

Pesado{
    peso:Integer
    passageiros:Integer
}
```


### *b)* 

```
Cliente{
    Chave candidata:  NIF , Num_carta
    Chave primária: NIF
    Chaves Estranjeiras: Nenhuma
}

Aluger{
    Chave candidata: Numero, (Cliente_NIF + Veiculo_Matricula + Balcao_Numero)
    Chave primária: Numero
    Chaves Estranjeiras: Cliente_NIF, Veiculo_Matricula, Balcao_Numero
}

Balcão{
    Chave candidata: Numero
    Chave primária: Numero
    Chaves Estranjeiras: Nenhuma
}

Veiculo{
    Chave candidata: Matricula
    Chave primária: Matricula
    Chaves Estranjeiras: Tipo_Veiculo_Codigo
}

Tipo_Veiculo{
    Chave candidata: Codigo
    Chave primária: Codigo
    Chaves Estranjeiras: Nenhuma
}

Ligeiro{
    Chave candidata: Não tem
    Chave primária: Não tem
    Chaves Estranjeiras: Tipo_Veiculo_Codigo
}

Pesado{
    Chave candidata: Não tem
    Chave primária: Não tem
    Chaves Estranjeiras: Tipo_Veiculo_Codigo
}
```


### *c)* 

![ex_3_1c!](ex_3_1c.svg "AnImage")


## ​Problema 3.2

### *a)*

```
... Write here your answer ...
```


### *b)* 

```
... Write here your answer ...
```


### *c)* 

![ex_3_2c!](ex_3_2c.jpg "AnImage")


## ​Problema 3.3


### *a)* 2.1

![ex_3_3_a!](ex_3_3a.jpg "AnImage")

### *b)* 2.2

![ex_3_3_b!](ex_3_3b.jpg "AnImage")

### *c)* 2.3

![ex_3_3_c!](ex_3_3c.jpg "AnImage")

### *d)* 2.4

![ex_3_3_d!](ex_3_3d.jpg "AnImage")