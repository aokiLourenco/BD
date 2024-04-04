-- a)
SELECT *
    FROM authors

----------------------------------

-- b)
Select authors.au_fname, authors.au_lname, authors.au_phone
    FROM authors

----------------------------------

-- c)
SELECT au_fname , au_lname , phone
	FROM authors
	ORDER BY au_fname,au_lname ASC

----------------------------------

-- d)
SELECT au_fname AS first_name , au_lname AS last_name , phone AS telephone
	FROM authors
	ORDER BY au_fname, au_lname ASC

----------------------------------

-- e)


----------------------------------

--f)
SELECT pub_name
    FROM publishers
    WHERE pub_name LIKE '%Bo%'

----------------------------------

-- g)
SELECT DISTINCT pub_name
    FROM publishers
        INNER JOIN titles AS tittles_1 ON publishers.pub_id = tittles_1.pub_id
    WHERE type = 'business'


----------------------------------

-- h)
SELECT publishers.pub_name, SUM(sales.qty) as total_sales
    FROM sales
        INNER JOIN titles ON sales.title_id = titles.title_id
        INNER JOIN publishers ON titles.pub_id = publishers.pub_id
    GROUP BY publishers.pub_name
    ORDER BY publishers.pub_name

----------------------------------

-- i)
SELECT publishers.pub_name, titles.title, SUM(sales.qty) as total_sales
    FROM sales
        INNER JOIN titles ON sales.title_id = titles.title_id
        INNER JOIN publishers ON titles.pub_id = publishers.pub_id
    GROUP BY publishers.pub_name, titles.title
    ORDER BY publishers.pub_name, titles.title

----------------------------------

-- k)
SELECT authors.au_fname, authors.au_lname, COUNT(*) AS types_c
    FROM authors
        INNER JOIN titleauthor ON authors.au_id = titleauthor.au_id
        INNER JOIN titles ON titleauthor.title_id = titles.title_id
    GROUP BY authors.au_fname, authors.au_lname
    HAVING COUNT(DISTINCT titles.type) > 1

----------------------------------

-- m)
SELECT title1.type
    FROM titles title1
        INNER JOIN (
            SELECT titles.type, MAX(titles.advance) AS max_advance, AVG(titles.advance) AS avg_advance
                FROM titles
                GROUP BY titles.type
        ) title2
        ON title1.type = title2.type
    WHERE title1.advance > 1.5 * title2.avg_advance

SELECT titles.type
    FROM titles
    GROUP BY titles.type
    HAVING MAX(titles.advance) > 1.5 * AVG(titles.advance)

----------------------------------

-- o)
SELECT titles.title, titles.ytd_sales, titles.ytd_sales * titles.price AS profit, 
                                        titles.ytd_sales * titles.price * titles.royalty / 100 AS auth_revenue,
                                        titles.price * titles.ytd_sales - titles.price * titles.ytd_sales * titles.royalty / 100 AS pub_revenue
    FROM titles
	ORDER BY titles.title

----------------------------------
