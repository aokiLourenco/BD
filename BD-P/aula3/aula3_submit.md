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

Similaridade{
    Chave candidate: Não tem
    Chave primária: Não tem
    Chaves Estranjeiras: Tipo_Veiculo_Codigo,Tipo_Veiculo_Codigo
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
Flight(
    Number:Integer,
    
    Airline:String,
    Weekdays:String
 );

Flight_Leg(
    Flight_Number:Integer,
    Leg_no:Integer,

    Departure_Airport:Integer,
    Arrival_Airport:Integer,
    Schedule_dep_time:String,
    Schedule_dep_time:String
 );

Leg_Instance(
    Date:String,
    Flight_leg_Flight_Number:Integer,
    Flight_leg_Leg_no:Integer,

    Airplane_id:Integer,
    Departs_Airport_Time:Integer,
    Arrival_Airport_time:Integer,
    Airport_Airport_code:Integer,
 );

Seat(
    Seat_no:Integer,
    Date:String,
    Flight_leg_Flight_Number:Integer,
    Flight_leg_Leg_no:Integer,

    Reservation_Customer_name:String,
    Reservation_Cphone:Integer,
 );

Airport(
    Airport_code:Integer,
    City:String,
    State:String,
    Name:String
 );

Airplane_Type(
    Type_name:String,
    Max_seats:Integer,
    Company:String
 );

Airplane(
    Airplane_id:Integer,
    Airplane_Type_name:String

    Total_no_of_seats:Integer,
 );
 
Fare(
    Flight_Number:Integer,
    Code:Integer,

    Restrictions:String,
    Amount:Integer
 );
 
```


### *b)* 

```
Flight{
    Chave candidata:Number
    Chave primária:Number
    Chaves Estranjeiras:None
}

Flight_Leg{
    Chave candidata: (Leg_no + Flight_Number)
    Chave primária: (Leg_no + Flight_Number)
    Chaves Estranjeiras: Flight_Number
}

Leg_Instance{
    Chave candidata: (Date + Leg_no + Flight_Number)
    Chave primária: (Date + Leg_no + Flight_Number)
    Chaves Estranjeiras: (Leg_no + Flight_Number)
}

Seat{
    Chave candidata: (Seat_no + Date + Leg_no + Flight_Number)
    Chave primária: (Seat_no + Date + Leg_no + Flight_Number)
    Chaves Estranjeiras: (Date + Leg_no + Flight_Number)
}

Airport{
    Chave candidata: Airport_code
    Chave primária: Airport_code
    Chaves Estranjeiras: None
}

Airplane_Type{    
    Chave candidata: Type_name
    Chave primária: Type_name
    Chaves Estranjeiras: None
}

Airplane{
    Chave candidata: (Airplane_id + Airplane_Type_Name)
    Chave primária: Airplane_id
    Chaves Estranjeiras: Airplane_Type_Name
}

Fare{
    Chave candidata: (Code + Flight_Number)
    Chave primária: (Code + Flight_Number)
    Chaves Estranjeiras: Flight_Number
}

Can_Land{
    Chave candidata:
    Chave primária:
    Chaves Estranjeiras:
}



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