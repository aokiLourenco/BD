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
... Write here your answer ...
```


### *d)* 

```
... Write here your answer ...
```


### *e)* 

```
π Fname, Lname σ Essn = null (employee ⟕ Ssn = Essn works_on)
```


### *f)* 

```
... Write here your answer ...
```


### *g)* 

```
... Write here your answer ...
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
