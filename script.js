const faces = new Set()
for (let eyes of [':',';'])
    for (let nose of ['-','~',''])
        for (let mouth of [')','D'])
            faces.add(eyes+nose+mouth)

countSmileys =(arr)=> arr.filter(x => faces.has(x)).length