//convert underscore and dashes into camel case

function toCamelCase(str){
  let result; 

  if (str.includes("-")){
    result = str.split("-")
  }
  else {
     result = str.split("_")
  }

  resultZero = result[0].toLowerCase();
  result[0] = resultZero;

  for (let i = 1; i < result.length; i++){
    let word = result[i].toUpperCase().split("");
    result[i] = word;
    for (let j = 1; j < result[i].length; j++){
      let wordTwo = result[i][j].toLowerCase();
      result[i][j] = wordTwo
    }
    result[i] = result[i].join("");
  }
  result = result.join("");

  return result;
  }


  console.log(toCamelCase("the-stealth-warrior"));
  console.log(toCamelCase("The_Stealth_Warrior"));