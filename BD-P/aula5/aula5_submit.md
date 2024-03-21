# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```
Write here your answer e.g:
(π Pname, Pnumber (project) ⨝ Pno=Pnumber (works_on)) ⨝.... 
```


### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
γ Pname; THours←sum(Hours)
(
project
⨝Pnumber=Pno
works_on
)
```


### *d)* 

```
(π Fname, Minit, Lname σ Dnumber=3 ∧ Hours>20 ∧ Pname='Aveiro Digital'
(employee
⨝Ssn=Essn
(department
⨝Dnumber=Dnum
(
project
⨝Pnumber=Pno
works_on
))))
```


### *e)* 

```
... Write here your answer ...
```


### *f)* 

```
γ Dname;
avgSalary←avg(Salary) σ Sex='F'
(
department
⨝Dnumber=Dno
employee
)
```


### *g)* 

```
π Fname, Lname σ nDependentes > 2
(
γ Fname, Lname; count(Essn) -> nDependentes
(
employee
⨝Ssn=Essn
dependent
))
```


### *h)* 

```
... Write here your answer ...
```


### *i)* 

```
... Write here your answer ...
```


## ​Problema 5.2

### *a)*

```
π nome, nif
σ numero=null
(
fornecedor
⟕nif=fornecedor
encomenda
)
```

### *b)* 

```
(γ codProd; avg(unidades) -> nMed
(
encomenda
⨝numero=numEnc
item
))
```


### *c)* 

```
γ avg(produtos) -> mediaProd
(
γ numEnc; count(codProd) -> produtos
(
encomenda
⨝numero=numEnc
item
)
)
```


### *d)* 

```
γ fornecedor.nome, produto.nome; sum(item.unidades) -> unidades
(
produto
⨝codigo=codProd
item
⨝numEnc=numero
encomenda
⨝fornecedor=nif
fornecedor
)
```


## ​Problema 5.3

### *a)*

```
... Write here your answer ...
```

### *b)* 

```
... Write here your answer ...
```


### *c)* 

```
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```

### *e)* 

```
... Write here your answer ...
```

### *f)* 

```
... Write here your answer ...
```
