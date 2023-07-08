# TripPlan
TripPlan is a project to help you to plan a trip before you go.
## Phase 1: Personal Console Program
####  User Story:
    When I plan to a family trip, I need to search for several tourist attractions, resterants, hotels, 
    and google routes back and forth. 
    I would like to have a tool to help me plan a trip and share to my family members.
#### Target User:
    DIY ueser
    Tour Guide
    訪談：問題 痛點 解決方案
####  Goal: 
    Meet My Personal Need: Output Trip Plan text File and google route url to share to others
####  Architecture:
    A console program with minimun user interaction.
####  Features:
    1. The program read event collection text file. (events.csv)
    2. Read plan argument text file. (plan-arg.txt)
    3. Output Trip plan text file. (trip.txt)
####  User Interface: 
    Command menu: 
        1: Reload Plan-arg.txt and print on Screen
        2. Output trip.txt      
## Phase 2: Web Service on the cloud with Frontend / Backend seperat repos
####  User Story:
    A user can signup/login to an account. He can search for several tourist attractions, resterants, hotels, 
    and google routes back and forth. He can plan a trip and save a trip. Output the trip infomation to share others.    
####  Goal: 
    Meet car-drvie DIY users and Tour guide Needs: Output Trip Plan text File and google route url to share to others
####  Architecture:
    A cloud web service with minimun micorservices.
####  Features:
    1. Trip Planning & Google Map interface 
    2. Load/Save/Edit Personal Trip Plans     
####  User Interface:
    1. View/Edit trip plan link with Google map    
## Phase 3: Release to Public
## Phase 4: Receive Public Feedback and Continue Development Cycle
### Reference:
  1. 來去遊 [TimePipe Go](https://www.timepipe.com/mytrip)
  2. [inspirock](https://www.inspirock.com/)
