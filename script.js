// return masked string
function pigIt(str){
  let result = str.split(" ");
  console.log(result); 

  for (let i=0; i<result.length; i++){
    individualArray = result[i].split("");
    console.log(individualArray)
    for (let j=0; j<individualArray.length; j++){
      if (individualArray.length === 1){
        continue;
      }
      resultTwo = individualArray[j].shift();
      console.log(resultTwo);
    }
  }


}

pigIt("I love gummies!");