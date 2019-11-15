Answer: 
Since there are many combinations of ways to display a list, and way to store/sort the
list information, it would be better to define multiple abstractions and implementations. The
Bridge pattern would the most appropriate to be used in this case. The abstractions are list
presentations (listed items, items with bullets, numbered items) while the implementations cab
be the way how the list are sorted (unordered list, a due date ordered list or a priority based
ordered task list).


![Image of Yaktocat](https://octodex.github.com/images/yaktocat.png)
