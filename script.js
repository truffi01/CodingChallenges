function tickets(peopleInLine){
  
  let twentyFive = []
  let fifty = []
  let oneHundred = []
  
  for (let i = 0; i < peopleInLine.length; i++){
    if (peopleInLine[i] === 25){
      twentyFive.push(peopleInLine[i])
    }
    if (peopleInLine[i] === 50){
      fifty.push(peopleInLine[i])
    }

    if (peopleInLine[i] === 50){
      if (twentyFive.length>1){
        twentyFive.pop();
      }
      else {
        return "No"
      }
    }

    if (peopleInLine[i] === 100){
      if (twentyFive.length>1 && fifty.length>1){
        twentyFive.pop();
        fifty.pop();
      }
    }

    if (peopleInLine[i] === 100){
      if (twentyFive.length>2){
        twentyFive.pop();
        twentyFive.pop();
        twentyFive.pop();
        console.log("1")
      }
      else {
        return "No"
      }
    }


  }
  return 'Yes'
}
  
console.log(tickets([25,25,25,100]));