//range extraction

function solution(list){
  //sort iwll sort the numbers from least to greatest
  let sortedList = list.sort((a,b) => a-b);
  console.log(sortedList);
  let result = []
  //code for the range of three numbers
  for (let i = 0; i <sortedList.length; i++){
    if (Math.abs(sortedList[i] - sortedList[i+1] - sortedList[i+2]) === 1) {
      result.push("-" + (-sortedList[i]) + "-" + (-sortedList[i+2]))
      i+=2;
    }

    if (sortedList[i+2] - sortedList[i+1] + sortedList[i] === sortedList[i+1]){
      result.push(sortedList[i] + "-" + sortedList[i+2])
      i+=2;
    }


  }
console.log(result);

}


console.log(solution([-4,-3,-2,0,1,4,6,7,8,9,10,14,15]));