db = db.getSiblingDB('presentation');
printjson(db.getCollectionNames());
print(db.presentatation.remove({}));
db.presentation.insert({
	presentation_title: "Pragmatic Programming",
	author: "Nicole Ruduss",
	pages: [{
			page_title: "Page 1",
			body: "Page body of page 1 <bold> hello </bold>",
			order: 1
	},
	{
			page_title: "Page 2",
			body: "Page body of page 2 <bold> hello </bold>",
			order: 2
	},
	{
			page_title: "Page 3",
			body: "Page body of page 3 <bold> hello </bold>",
			order: 3
	}]
})
cursor = db.presentation.find();
while(cursor.hasNext()){
	printjson(cursor.next());
}