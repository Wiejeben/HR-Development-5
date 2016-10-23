// function() {
//     emit(this._id, { Employee: this }); 
// }
 
// function(key, employee) {
    // var result = { Projects: [], Hours: 0 };

    // employee.Projects.forEach(
    //     function(project) {
    //         result.Projects.push(project.ProjectId);

    //         project.Positions.forEach(
    //             function(position) {
    //                 result.Hours += position.Hours;
    //             }
    //         )
    //     }
    // );

    // return result;
// }


function() {
    emit(this._id, { 'amount': 0 })
}

function(key, results) {

    results.forEach(
        function(result)
        {
            var employees = db.employees.find({ 'Projects.PositionId': key });

            var overworked = 0;

            employees.forEach(
                function(employee)
                {
                    var hours = 0;

                    employee.Projects.forEach(
                        function(project)
                        {
                            project.Positions.forEach(
                                function(position)
                                {
                                    hours += position.Hours;
                                }
                            )
                        }
                    );

                    if (hours > 20)
                    {
                        overworked++;
                    }
                }
            );

            result.amount = overworked;
        }
    );
    
    return results;
}