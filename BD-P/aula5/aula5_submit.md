# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```
π Fname, Lname, Ssn, Pname (employee ⨝ Ssn = Essn works_on ⨝ Pno = Pnumber project)
```


### *b)* 

```
π employee.Fname, employee.Lname, employee.Ssn, employee.Super_ssn ( σ Chefe.Fname = 'Carlos' and Chefe.Lname = 'Gomes' (employee ⨝ employee.Super_ssn = Chefe.Ssn ρ Chefe employee))
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
π Fname, Lname σ Essn = null (employee ⟕ Ssn = Essn works_on)
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
π employee.Fname, employee.Minit, employee.Lname ( σ Essn = null (employee ⟕ Ssn = Essn dependent) ⨝ employee.Ssn = Gestor_Department.Ssn ρ Gestor_Department (employee ⨝ Ssn = Mgr_ssn department))
```


### *i)* 

```
π Fname, Minit, Lname, Address ( σ Dlocation ≠ 'Aveiro' (dept_location ⨝ Dnumber = Dno σ Plocation = 'Aveiro' (employee ⨝ Ssn = Essn works_on ⨝ Pno = Pnumber project)))
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
π nome ( σ prescricao.numPresc = null (paciente ⟕ paciente.numUtente = prescricao.numUtente prescricao))
```

### *b)* 

```
γ especialidade; COUNT(especialidade)→Npresc (medico ⨝ numSNS = numMedico prescricao)
```


### *c)* 

```
γ farmacia; COUNT(numPresc)→N_presc (prescricao ⨝ farmacia = nome farmacia)
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
