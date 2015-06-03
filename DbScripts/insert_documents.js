
db = db.getSiblingDB('presentation');
db.getCollectionNames();
db.dropDatabase();
db.presentation.insert({
   presentation_title: "Pragmatic Programming",
   author: "Nicole Ruduss",
   pages: [{
              page_title: "Pragmatic Programming",
              body: "",
              order: 1
            },
{
              page_title: "Topics of Discussion",
              body: "<ul><li>What is it</li><li>Wisdom</li><li>Responsibility</li><li>Entropy</li><li>Debugging</li><li>DRY</li><li>Pragmatic Teams</li></ul>",
              order: 2
            },
{
              page_title: "What is it?",
              body: "<ul><li>Principles from a book first published in 2004</li><li>Written by programmers about applying common sense to your development work</li><li>Collection of tips, told by way of advice relating to software development</li><li>If followed then they should help you to become a better programmer</li></ul>",
              order: 3
            },
{
              page_title: "...and more of What is it?",
              body: "<ul><li>In the book there's around 70 tips to follow in total</li><li>I will be going through each one in detail</li></ul>",
              order: 4
            },
{
              page_title: "",
              body: "only joking ..... ",
              order: 5
            },
{
              page_title: "Wisdom",
              body: "<ul><li>W ~ What do you want them to learn?</li><li>I ~ What is their interest in what you’ve got to say?</li><li>S ~ How sophisticated is the audience?</li><li>D ~How much detail do they want?</li><li>O ~ Whom do you want to own the information?</li><li>M ~ How can I motivated you to listen to me?</li></ul>",
              order: 6
            },
{
              page_title: "Taking Responsibility",
              body: "<ul><li>Responsibility for your actions in terms of your career, current project, and day to day work.</li><li>Admitting your ignorances</li><li>Making sure your commitments are done right</li><li>Not making excuses</li><li>Stop and listen to your explanation as to why something can’t be done</li>  </ul>",
              order: 7
            },
{
              page_title: "Software Entropy",
              body: "<ul>  <li>How much disorder there is in a system</li><li>Broken windows</li><li>Cracking down on the small stuff</li>  </ul>",
              order: 8
            },
{
              page_title: "Debugging",
              body: "<ul>  <li>Fix the problem, not the blame</li><li>Don’t panic</li><li>Beware of nearsightedness</li></ul>",
              order: 9
            },
{
              page_title: "DRY - Don’t Repeat Yourself",
              body: "<ul>  <li>Define each piece of knowledge or logic in the one place</li><li>Duplication may not be obvious</li><li>Reduces maintenance</li><li>Minimises lines of code</li><li>Beware of copy and pastte</li></ul>",
              order: 10
            },
{
              page_title: "DRY - Don’t Repeat Yourself",
              body: "<ul><li>Define each piece of knowledge or logic in the one place</li><li>Duplication may not be obvious</li><li>Reduces maintenance</li><li>Minimises lines of code</li><li>Beware of copy and paste</li></ul>",
              order: 11
            },
{
              page_title: "Pragmatic Teams",
              body: "<ul><li>How do you apply this to your team?</li><li>Don’t leave the broken windows to the one person to fix</li><li>Encouragement is key</li>  </ul>  ",
              order: 12
            },
{
              page_title: "And in summary",
              body: "",
              order: 13
            },
{
              page_title: "",
              body: "But one more thing rule to keep in mind....",
              order: 14
            },
{
              page_title: "",
              body: "<ul><li>K</li><li>I</li><li><a href='~/Home/About'>f</a></li><li>S</li><li>S</li></ul>",
              order: 15
            }
]
});
cursor = db.collection.find();
while ( cursor.hasNext() ) {
   printjson( cursor.next() );
};
