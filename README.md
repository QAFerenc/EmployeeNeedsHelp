# EmployeeNeedsHelp
Employee would like to find the optimal way to ask help from others

Task : 

It’s another day in the office, and you’re a mastermind of not doing any work yourself. Instead, you’ll go to your coworkers for “help,” but secretly have them do all the work.

You’ve determined that the more one of your coworkers helps you, the more annoyed they become. You’ve also been able to determine how much more annoyed a coworker gets everytime you ask them for help. At the beginning of the day, a coworker is initially  annoyed at you. That’s their annoyance level. Everytime you ask them for help though, they become  more annoyed at you – their annoyance level  increases by a constant amount  so that .

You want to complete a project of  tasks solely with “help” from your coworkers, but you need to be careful not to annoy any of them too much.

What’s the best you can do?

Input
The first line contains  integers  and , where  () is the number of times you have to ask for help to complete the project, and  () denotes the number of coworkers you have.

Each of the following  lines contains two positive integers  and , representing a coworker whose initial annoyance level is  and who is getting more annoyed at you by an increase of  every time you ask them for help ().

Output
Output a single number, which is the maximum annoyance level any coworker has at you provided you use an optimal strategy to minimize this level. (In other words, of all possible strategies, choose one that minimizes the annoyance level of the worker or workers who are most annoyed at you at the end.)

Sample Input 1 Explanation
You have  coworkers and you need to ask for help  times. Initially, their annoyance levels are , the increases are . One optimal solution is to ask for help twice from coworker , once from coworker , and once from coworker , in which case the final annoyance levels are: . The coworker that is most annoyed at you is coworker , whose annoyance level at you is . Or, you could ask coworker  for help  times and coworker  once, leaving you with . Both strategies yield the same minimal maximum amount.

Sample Input 1	Sample Output 1
4 4
1 2
2 3
3 4
4 5
7

Sample Input 2	Sample Output 2
3 2
1 1000
1000 1
1002

Sample Input 3	Sample Output 3
5 2
1 1
2 2
5

