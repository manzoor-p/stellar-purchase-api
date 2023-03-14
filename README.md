# stellar-purchase-api


PuchasePointCalcApi request and response

curl --location 'https://localhost:7053/api/customer/purchasePointDetails?startDate=2023-01-01&endDate=2023-03-31' \
--header 'Api-Key: f7370184-1674-48f6-b9d2-cb228dd0d92e-f7370184-1674-48f6-b9d2-cb228dd0d92e' \
--data '' 

``` json
[
    {
        "customerName": "Abhishek Mishra",
        "email": "abhishek.mishra@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 200
            },
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 346
            }
        ],
        "totalPoints": 546
    },
    {
        "customerName": "Vinay Kumar",
        "email": "vinay@gmail.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 140
            }
        ],
        "totalPoints": 140
    },
    {
        "customerName": "Rohit Kumar",
        "email": "rohit.kumar@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 618
            }
        ],
        "totalPoints": 618
    },
    {
        "customerName": "Sanjay Singh",
        "email": "sanjay.singh@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 308
            },
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 320
            },
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 264
            }
        ],
        "totalPoints": 892
    },
    {
        "customerName": "Kunal Sharma",
        "email": "kunal.sharma@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 19
            },
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 132
            }
        ],
        "totalPoints": 151
    },
    {
        "customerName": "Anjali Gupta",
        "email": "anjali.gupta@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 56
            },
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 5
            }
        ],
        "totalPoints": 61
    },
    {
        "customerName": "Sujata Sahoo",
        "email": "sujata.sahoo@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 278
            }
        ],
        "totalPoints": 278
    },
    {
        "customerName": "Rajesh Khanna",
        "email": "rajesh.khanna@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 134
            },
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 150
            }
        ],
        "totalPoints": 284
    },
    {
        "customerName": "Priya Patel",
        "email": "priya.patel@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 75
            }
        ],
        "totalPoints": 75
    },
    {
        "customerName": "Rahul Sharma",
        "email": "rahul.sharma@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 3,
                "monthlySum": 0
            },
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 0
            },
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 0
            }
        ],
        "totalPoints": 0
    },
    {
        "customerName": "Manzoor Ahmed",
        "email": "manzoor@hotmail.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 268
            }
        ],
        "totalPoints": 268
    },
    {
        "customerName": "Mahesh Kumar Patil",
        "email": "mahesh@gmail.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 324
            }
        ],
        "totalPoints": 324
    },
    {
        "customerName": "Manisha Chauhan",
        "email": "manisha.chauhan@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 2,
                "monthlySum": 102
            }
        ],
        "totalPoints": 102
    },
    {
        "customerName": "Shweta Singh",
        "email": "shweta.singh@stellar.com",
        "monthlyPoints": [
            {
                "year": 2023,
                "month": 1,
                "monthlySum": 188
            }
        ],
        "totalPoints": 188
    }
]
```

Customers table data
|idCustomer                          |Name              |Email                      |
|------------------------------------|------------------|---------------------------|
|013ff91b-fd27-496f-8de2-7a93e58c7d7f|Nisha Gupta       |nisha.gupta@stellar.com    |
|0617c8b8-a7f2-46c6-871d-d3f9306d901d|Abhishek Mishra   |abhishek.mishra@stellar.com|
|08db1d58-2836-468a-8e3d-0ce8578fa1af|Dell BOT          |dellbot@dell.com           |
|08db1d58-2836-468c-8f4e-55743b252cc6|Dell BOT          |dellbot@dell.com           |
|342c354c-143f-4724-a1c2-79ce13f60d9a|Vinay Kumar       |vinay@gmail.com            |
|46e8f34f-719a-4db9-8f2f-84a69b1dce17|Rohit Kumar       |rohit.kumar@stellar.com    |
|5288610c-8bea-4138-8aa4-9701448c99c0|Neha              |neha@gmail.com             |
|676b6a06-b71d-4c03-90f2-91eeb14fe899|Sanjay Singh      |sanjay.singh@stellar.com   |
|761dc018-10a6-4199-a6ed-7a746dd5a9ec|Kunal Sharma      |kunal.sharma@stellar.com   |
|7ae7a200-0796-4ff3-9e92-c3285f2559ef|Anjali Gupta      |anjali.gupta@stellar.com   |
|7d5a2f8e-eb94-443b-9405-550b796ba4ea|Sujata Sahoo      |sujata.sahoo@stellar.com   |
|85e818fc-234b-4796-af23-ec58749ef3e7|Rajesh Khanna     |rajesh.khanna@stellar.com  |
|880f2867-8461-402c-a3bd-c3528222d749|Priya Patel       |priya.patel@stellar.com    |
|8a1f990f-eb8f-4700-9a4e-85e862200770|Rahul Sharma      |rahul.sharma@stellar.com   |
|9b87b25e-be2d-4550-91e6-0b51996f9ec9|Manzoor Ahmed     |manzoor@hotmail.com        |
|a7821728-0666-429a-80b5-9078ed4366b4|Mahesh Kumar Patil|mahesh@gmail.com           |
|c4bd815e-40b1-4376-91ec-cce711b48e3d|Manisha Chauhan   |manisha.chauhan@stellar.com|
|c78b20a2-1562-412a-ae8c-7c6ed600d9f7|Jane Smith        |jane.smith@stellar.com     |
|cfdeec8d-765a-4c5e-a790-06f510dcdbda|Vivek Pandey      |vivek.pandey@stellar.com   |
|d9b3c8a3-e41a-47f6-86e2-2d0cbf0cdecd|John Doe          |john.doe@stellar.com       |
|f87067e4-ea55-4e7d-b708-c87fe292fc06|Deepika           |deepika@dell.com           |
|fc6d61d5-b627-4ff6-ab4c-5c329d9624db|Shweta Singh      |shweta.singh@stellar.com   |
|fd7c7498-cbff-41c2-95dc-2309c3a14647|Bob Johnson       |bob.johnson@stellar.com    |


Purchases Table data
|idPurchase                          |idCustomer        |PurchaseDate               |TotalAmount|
|------------------------------------|------------------|---------------------------|-----------|
|0362ac96-9b2d-4f09-8690-fd4206b73fed|8a1f990f-eb8f-4700-9a4e-85e862200770|2022-10-31 00:00:00        |10.00      |
|0618d50f-a802-4607-bcd7-a3fa649bfe08|9b87b25e-be2d-4550-91e6-0b51996f9ec9|2023-01-03 00:00:00        |149.00     |
|18d0b210-b86d-46df-99f1-f0392ef6b717|8a1f990f-eb8f-4700-9a4e-85e862200770|2022-12-03 00:00:00        |75.99      |
|1df6d19b-9bf5-4cf7-ba56-59e54269743d|fd7c7498-cbff-41c2-95dc-2309c3a14647|2022-03-09 00:00:00        |125.00     |
|38391a5c-7bd7-44fc-b287-81c61323e485|880f2867-8461-402c-a3bd-c3528222d749|2023-03-14 00:00:00        |100.00     |
|430d1a20-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2023-01-14 22:02:00        |229.99     |
|430d5396-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2023-02-27 18:31:00        |103.01     |
|430d56c1-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2022-12-22 09:27:00        |37.24      |
|430d587c-c27b-11ed-9728-b445066ac8d5|7d5a2f8e-eb94-443b-9405-550b796ba4ea|2022-11-06 13:07:00        |170.57     |
|430d5a5a-c27b-11ed-9728-b445066ac8d5|0617c8b8-a7f2-46c6-871d-d3f9306d901d|2023-02-11 20:15:00        |175.65     |
|430d5d3f-c27b-11ed-9728-b445066ac8d5|c4bd815e-40b1-4376-91ec-cce711b48e3d|2022-11-12 02:49:00        |32.28      |
|430d5fc1-c27b-11ed-9728-b445066ac8d5|85e818fc-234b-4796-af23-ec58749ef3e7|2023-02-16 15:26:00        |142.35     |
|430d6224-c27b-11ed-9728-b445066ac8d5|fc6d61d5-b627-4ff6-ab4c-5c329d9624db|2022-12-23 03:46:00        |164.26     |
|430d646c-c27b-11ed-9728-b445066ac8d5|761dc018-10a6-4199-a6ed-7a746dd5a9ec|2023-03-01 04:47:00        |69.66      |
|47eec29a-12a7-4d34-8125-736a7d8772f8|9b87b25e-be2d-4550-91e6-0b51996f9ec9|2023-01-01 00:00:00        |100.00     |
|5275f792-9b61-4c76-bf5d-cee10b6ab6ea|a7821728-0666-429a-80b5-9078ed4366b4|2023-01-01 00:00:00        |112.00     |
|5e198a3d-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2023-02-11 09:03:00        |235.28     |
|5e19927e-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2022-12-27 08:59:00        |153.43     |
|5e199422-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2023-01-06 17:28:00        |227.63     |
|5e19956c-c27b-11ed-9728-b445066ac8d5|7d5a2f8e-eb94-443b-9405-550b796ba4ea|2023-03-15 10:58:00        |214.07     |
|5e199660-c27b-11ed-9728-b445066ac8d5|0617c8b8-a7f2-46c6-871d-d3f9306d901d|2023-01-01 03:11:00        |248.62     |
|5e199768-c27b-11ed-9728-b445066ac8d5|c4bd815e-40b1-4376-91ec-cce711b48e3d|2022-12-20 09:52:00        |67.24      |
|5e199855-c27b-11ed-9728-b445066ac8d5|85e818fc-234b-4796-af23-ec58749ef3e7|2023-03-05 14:51:00        |150.00     |
|5e19994b-c27b-11ed-9728-b445066ac8d5|fc6d61d5-b627-4ff6-ab4c-5c329d9624db|2022-12-01 01:30:00        |234.83     |
|5e199a10-c27b-11ed-9728-b445066ac8d5|761dc018-10a6-4199-a6ed-7a746dd5a9ec|2023-01-30 15:00:00        |141.85     |
|6d1f6dd5-9e2c-42aa-8bf2-1c72a8a8400e|d9b3c8a3-e41a-47f6-86e2-2d0cbf0cdecd|2022-03-13 00:00:00        |50.00      |
|7555f085-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2023-02-10 07:32:00        |11.67      |
|7555f700-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2023-03-02 08:16:00        |55.02      |
|7555f800-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2022-12-14 17:10:00        |130.30     |
|7555f89a-c27b-11ed-9728-b445066ac8d5|7d5a2f8e-eb94-443b-9405-550b796ba4ea|2022-11-18 11:49:00        |210.59     |
|7555f929-c27b-11ed-9728-b445066ac8d5|0617c8b8-a7f2-46c6-871d-d3f9306d901d|2022-12-07 22:01:00        |98.51      |
|7555f9b2-c27b-11ed-9728-b445066ac8d5|c4bd815e-40b1-4376-91ec-cce711b48e3d|2023-02-08 00:13:00        |126.41     |
|7555fa7b-c27b-11ed-9728-b445066ac8d5|85e818fc-234b-4796-af23-ec58749ef3e7|2022-11-18 22:08:00        |225.13     |
|7555fb04-c27b-11ed-9728-b445066ac8d5|fc6d61d5-b627-4ff6-ab4c-5c329d9624db|2023-01-30 10:41:00        |169.78     |
|7555fb9b-c27b-11ed-9728-b445066ac8d5|761dc018-10a6-4199-a6ed-7a746dd5a9ec|2022-11-27 03:55:00        |149.65     |
|83a9c486-d419-4d87-b4ef-2d8c91035797|9b87b25e-be2d-4550-91e6-0b51996f9ec9|2023-01-02 00:00:00        |110.00     |
|8c1e9f60-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2023-03-24 02:19:00        |25.29      |
|8c1eaa4c-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2022-12-18 08:43:00        |243.67     |
|8c1eabfb-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2023-01-12 00:54:00        |232.11     |
|911ffb9e-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2023-03-16 10:36:00        |207.14     |
|912000e8-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2022-12-03 01:30:00        |76.67      |
|91200236-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2022-12-02 05:07:00        |222.45     |
|9238a130-c27b-11ed-9728-b445066ac8d5|676b6a06-b71d-4c03-90f2-91eeb14fe899|2022-12-11 11:48:00        |86.61      |
|9238a862-c27b-11ed-9728-b445066ac8d5|7ae7a200-0796-4ff3-9e92-c3285f2559ef|2022-12-14 10:09:00        |33.57      |
|9238a9bc-c27b-11ed-9728-b445066ac8d5|46e8f34f-719a-4db9-8f2f-84a69b1dce17|2022-11-16 14:38:00        |248.31     |
|a83fd61b-fd69-40f4-b41d-48ec8215b29d|342c354c-143f-4724-a1c2-79ce13f60d9a|2023-01-01 00:00:00        |145.00     |
|a8d3f6ad-470d-489e-9f10-6a77633d8a7a|8a1f990f-eb8f-4700-9a4e-85e862200770|2023-03-05 00:00:00        |22.50      |
|a919cd06-6f59-4afb-a5a4-536a778690d6|880f2867-8461-402c-a3bd-c3528222d749|2023-03-13 00:00:00        |50.00      |
|af29f42b-e797-4f65-b693-2f6a615153f7|8a1f990f-eb8f-4700-9a4e-85e862200770|2023-01-28 00:00:00        |45.75      |
|c12708a1-4bca-4d2a-b429-90867748e166|8a1f990f-eb8f-4700-9a4e-85e862200770|2022-11-25 00:00:00        |32.99      |
|c656c2ea-962a-424b-b76b-0cee7cd7e07e|8a1f990f-eb8f-4700-9a4e-85e862200770|2023-02-12 00:00:00        |50.75      |
|c811f6d8-f7a9-4a34-a6c4-6f1ad09dfe16|fd7c7498-cbff-41c2-95dc-2309c3a14647|2022-03-10 00:00:00        |30.00      |
|d6a5da6f-52f7-4686-9d34-9b5f10c5d5e5|c78b20a2-1562-412a-ae8c-7c6ed600d9f7|2022-03-11 00:00:00        |75.00      |
|db593851-bfc0-428f-ad2b-246d8d85aa2d|a7821728-0666-429a-80b5-9078ed4366b4|2023-01-03 00:00:00        |200.00     |
|f3c7ba68-832a-4b4e-9744-3f4b26dcd41c|d9b3c8a3-e41a-47f6-86e2-2d0cbf0cdecd|2022-03-12 00:00:00        |100.00     |
|fe0d3678-f1ec-418a-96b2-19aaf71ceb9f|880f2867-8461-402c-a3bd-c3528222d749|2023-03-12 00:00:00        |75.00      |
|feb16c3d-1c66-4cfd-9bdf-8280103fc709|8a1f990f-eb8f-4700-9a4e-85e862200770|2022-10-18 00:00:00        |25.50      |



All Customer's purchase details

select * from customers
select c.Name as customerName, p.PurchaseDate, p.TotalAmount 
from customers c inner join purchases p on c.idCustomer = p.idCustomer
order by c.Name

|customerName                        |PurchaseDate      |TotalAmount                |
|------------------------------------|------------------|---------------------------|
|Abhishek Mishra                     |2023-02-11 20:15:00|175.65                     |
|Abhishek Mishra                     |2023-01-01 03:11:00|248.62                     |
|Abhishek Mishra                     |2022-12-07 22:01:00|98.51                      |
|Anjali Gupta                        |2023-03-02 08:16:00|55.02                      |
|Anjali Gupta                        |2023-02-27 18:31:00|103.01                     |
|Anjali Gupta                        |2022-12-14 10:09:00|33.57                      |
|Anjali Gupta                        |2022-12-27 08:59:00|153.43                     |
|Anjali Gupta                        |2022-12-03 01:30:00|76.67                      |
|Anjali Gupta                        |2022-12-18 08:43:00|243.67                     |
|Bob Johnson                         |2022-03-09 00:00:00|125.00                     |
|Bob Johnson                         |2022-03-10 00:00:00|30.00                      |
|Jane Smith                          |2022-03-11 00:00:00|75.00                      |
|John Doe                            |2022-03-12 00:00:00|100.00                     |
|John Doe                            |2022-03-13 00:00:00|50.00                      |
|Kunal Sharma                        |2023-03-01 04:47:00|69.66                      |
|Kunal Sharma                        |2022-11-27 03:55:00|149.65                     |
|Kunal Sharma                        |2023-01-30 15:00:00|141.85                     |
|Mahesh Kumar Patil                  |2023-01-03 00:00:00|200.00                     |
|Mahesh Kumar Patil                  |2023-01-01 00:00:00|112.00                     |
|Manisha Chauhan                     |2022-11-12 02:49:00|32.28                      |
|Manisha Chauhan                     |2022-12-20 09:52:00|67.24                      |
|Manisha Chauhan                     |2023-02-08 00:13:00|126.41                     |
|Manzoor Ahmed                       |2023-01-01 00:00:00|100.00                     |
|Manzoor Ahmed                       |2023-01-03 00:00:00|149.00                     |
|Manzoor Ahmed                       |2023-01-02 00:00:00|110.00                     |
|Priya Patel                         |2023-03-14 00:00:00|100.00                     |
|Priya Patel                         |2023-03-13 00:00:00|50.00                      |
|Priya Patel                         |2023-03-12 00:00:00|75.00                      |
|Rahul Sharma                        |2022-10-31 00:00:00|10.00                      |
|Rahul Sharma                        |2022-11-25 00:00:00|32.99                      |
|Rahul Sharma                        |2023-03-05 00:00:00|22.50                      |
|Rahul Sharma                        |2023-01-28 00:00:00|45.75                      |
|Rahul Sharma                        |2022-10-18 00:00:00|25.50                      |
|Rahul Sharma                        |2023-02-12 00:00:00|50.75                      |
|Rahul Sharma                        |2022-12-03 00:00:00|75.99                      |
|Rajesh Khanna                       |2022-11-18 22:08:00|225.13                     |
|Rajesh Khanna                       |2023-02-16 15:26:00|142.35                     |
|Rajesh Khanna                       |2023-03-05 14:51:00|150.00                     |
|Rohit Kumar                         |2022-12-14 17:10:00|130.30                     |
|Rohit Kumar                         |2023-01-12 00:54:00|232.11                     |
|Rohit Kumar                         |2023-01-06 17:28:00|227.63                     |
|Rohit Kumar                         |2022-12-02 05:07:00|222.45                     |
|Rohit Kumar                         |2022-11-16 14:38:00|248.31                     |
|Rohit Kumar                         |2022-12-22 09:27:00|37.24                      |
|Sanjay Singh                        |2023-03-24 02:19:00|25.29                      |
|Sanjay Singh                        |2023-03-16 10:36:00|207.14                     |
|Sanjay Singh                        |2023-02-11 09:03:00|235.28                     |
|Sanjay Singh                        |2023-02-10 07:32:00|11.67                      |
|Sanjay Singh                        |2023-01-14 22:02:00|229.99                     |
|Sanjay Singh                        |2022-12-11 11:48:00|86.61                      |
|Shweta Singh                        |2022-12-01 01:30:00|234.83                     |
|Shweta Singh                        |2023-01-30 10:41:00|169.78                     |
|Shweta Singh                        |2022-12-23 03:46:00|164.26                     |
|Sujata Sahoo                        |2023-03-15 10:58:00|214.07                     |
|Sujata Sahoo                        |2022-11-18 11:49:00|210.59                     |
|Sujata Sahoo                        |2022-11-06 13:07:00|170.57                     |
|Vinay Kumar                         |2023-01-01 00:00:00|145.00                     |
