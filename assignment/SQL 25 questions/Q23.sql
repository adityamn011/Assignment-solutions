SELECT ord_no, purch_amt, ord_date, customer_id,salesman_id FROM orders
WHERE purch_amt BETWEEN 500 AND 4000
AND purch_amt NOT IN (948.50,1983.43)
 