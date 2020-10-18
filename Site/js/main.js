// fetch('https://jsonplaceholder.typicode.com/posts', {
//   method: 'POST',
//   body: JSON.stringify({
//     title: 'foo',
//     body: 'bar',
//     userId: 1,
//   }),
//   headers: {
//     'Content-type': 'application/json; charset=UTF-8',
//   },
// })
//   .then((response) => response.json())
//   .then((json) => {
//     console.log(json);
//     fetch('https://jsonplaceholder.typicode.com/todos/1')
//       .then(response => response.json())
//       .then(json => console.log(json))
//   })

// google.charts.load('current', { 'packages': ['gantt'] });
// google.charts.setOnLoadCallback(drawChart);

// function daysToMilliseconds(days) {
//   return days * 24 * 60 * 60 * 1000;
// }

// function drawChart() {

//   var data = new google.visualization.DataTable();
//   data.addColumn('string', 'Task ID');
//   data.addColumn('string', 'Task Name');
//   data.addColumn('date', 'Start Date');
//   data.addColumn('date', 'End Date');
//   data.addColumn('number', 'Duration');
//   data.addColumn('number', 'Percent Complete');
//   data.addColumn('string', 'Dependencies');

//   data.addRows([
//     ['Research', 'Find sources',
//       new Date(2015, 0, 1), new Date(2015, 0, 5), null, 100, null],
//     ['Write', 'Write paper', new Date(2015, 0, 3), new Date(2015, 0, 4), daysToMilliseconds(1), 10, 'Research'],
//   ]);

//   var options = {

//   };

//   var chart = new google.visualization.Gantt(document.getElementById('gantt-diagramm'));

//   chart.draw(data, options);
// }

// drawChart()


// let tasks = [
//     {
//         id: 'Task 1',
//         name: 'Redesign website 1',
//         start: '2016-12-8',
//         end: '2016-12-31',
//         progress: 40,
//         dependencies: ''
//     },
//     {
//         id: 'Task 2',
//         name: 'Redesign website 2',
//         start: '2016-12-20',
//         end: '2016-12-25',
//         progress: 20,
//         dependencies: 'Task 1,'
//     },
//     {
//         id: 'Task 3',
//         name: 'Redesign website 3',
//         start: '2016-12-29',
//         end: '2016-12-31',
//         progress: 20,
//         dependencies: 'Task 1,Task 2'
//     },
//     {
//         id: 'Task 4',
//         name: 'Redesign website 4',
//         start: '2016-12-27',
//         end: '2016-12-30',
//         progress: 90,
//         dependencies: 'Task 2'
//     },
//     {
//         id: 'Task 5',
//         name: 'Redesign website 4',
//         start: '2016-12-20',
//         end: '2016-12-25',
//         progress: 50,
//         dependencies: 'Task 4'
//     }
// ]

var json = '[{"id":"d1428a29-1c0a-4c31-a77c-16845a3a059e","name":"271f2...","start":"2020-01-17T00:00:00","Finish":"0001-01-01T00:00:00","Duration":2,"progress_min":1,"price_earlier":24,"price_late":29,"price_durationc_changed":9,"stage_id":"6ad5d674-fef2-42a0-be74-a9dfcc738191","project_id":null,"progress":50.0,"end":"2020-01-19T00:00:00"},{"id":"a69f7719-5cbf-433c-9875-11db2cd33fe7","name":"bc8c7...","start":"2020-01-09T00:00:00","Finish":"0001-01-01T00:00:00","Duration":10,"progress_min":2,"price_earlier":13,"price_late":39,"price_durationc_changed":48,"stage_id":"6ad5d674-fef2-42a0-be74-a9dfcc738191","project_id":null,"progress":20.0,"end":"2020-01-19T00:00:00"},{"id":"35428fa9-7bc0-4305-a90a-27d59670a92f","name":"f8160...","start":"2020-11-24T00:00:00","Finish":"0001-01-01T00:00:00","Duration":2,"progress_min":0,"price_earlier":26,"price_late":0,"price_durationc_changed":38,"stage_id":"285aa9d0-56d3-434f-9700-4d9805650eb2","project_id":null,"progress":0.0,"end":"2020-11-26T00:00:00"},{"id":"80d80d45-3d78-410e-a4ca-83279c904fec","name":"346ba...","start":"2020-05-05T00:00:00","Finish":"0001-01-01T00:00:00","Duration":21,"progress_min":1,"price_earlier":19,"price_late":40,"price_durationc_changed":8,"stage_id":"6ad5d674-fef2-42a0-be74-a9dfcc738191","project_id":null,"progress":4.761904761904762,"end":"2020-05-26T00:00:00"},{"id":"ce113e2c-c81e-4829-b065-36fa49e11214","name":"9da73...","start":"2020-08-21T00:00:00","Finish":"0001-01-01T00:00:00","Duration":14,"progress_min":7,"price_earlier":6,"price_late":43,"price_durationc_changed":39,"stage_id":"f2bc203c-06cd-4d77-a2dd-7c74de3ff791","project_id":null,"progress":50.0,"end":"2020-09-04T00:00:00"},{"id":"35c00194-4354-48f0-8cd6-0370cdb3754a","name":"4c49f...","start":"2020-11-19T00:00:00","Finish":"0001-01-01T00:00:00","Duration":0,"progress_min":0,"price_earlier":-1,"price_late":33,"price_durationc_changed":18,"stage_id":"285aa9d0-56d3-434f-9700-4d9805650eb2","project_id":null,"progress":"NaN","end":"2020-11-19T00:00:00"},{"id":"abbb073d-4aa2-491a-93ca-37732992d895","name":"651fd...","start":"2020-04-14T00:00:00","Finish":"0001-01-01T00:00:00","Duration":6,"progress_min":2,"price_earlier":14,"price_late":16,"price_durationc_changed":47,"stage_id":"285aa9d0-56d3-434f-9700-4d9805650eb2","project_id":null,"progress":33.33333333333333,"end":"2020-04-20T00:00:00"},{"id":"772538b2-4ab5-484d-b45b-9e19ecbcf26e","name":"7d154...","start":"2020-06-24T00:00:00","Finish":"0001-01-01T00:00:00","Duration":10,"progress_min":4,"price_earlier":40,"price_late":26,"price_durationc_changed":43,"stage_id":"285aa9d0-56d3-434f-9700-4d9805650eb2","project_id":null,"progress":40.0,"end":"2020-07-04T00:00:00"},{"id":"911c38c3-a5a9-434f-a903-8516e67674fd","name":"47bf0...","start":"2020-04-27T00:00:00","Finish":"0001-01-01T00:00:00","Duration":15,"progress_min":0,"price_earlier":14,"price_late":3,"price_durationc_changed":15,"stage_id":"6ad5d674-fef2-42a0-be74-a9dfcc738191","project_id":null,"progress":0.0,"end":"2020-05-12T00:00:00"},{"id":"67fcf9fd-c56f-4b0f-97a8-59d8dbdd4193","name":"901a8...","start":"2020-01-12T00:00:00","Finish":"0001-01-01T00:00:00","Duration":25,"progress_min":5,"price_earlier":40,"price_late":9,"price_durationc_changed":-1,"stage_id":"285aa9d0-56d3-434f-9700-4d9805650eb2","project_id":null,"progress":20.0,"end":"2020-02-06T00:00:00"}]';
var tasks3 = JSON.parse(json);

var tasks1 = [{
    id: '1',
    name: 'Строительство дома',
    start: '2020-03-24T00:00:00',
    progress: 0,
    end: '2020-04-15T00:00:00',
    dependencies: ''
},
{
    id: '2',
    name: 'Установка фундамента',
    start: '2020-03-24T00:00:00',
    progress: 0,
    end: '2020-03-30T00:00:00',
    dependencies: ''
},
{
    id: '3',
    name: 'Установка стен',
    start: '2020-03-30T00:00:00',
    progress: 0,
    end: '2020-04-10T00:00:00',
    dependencies: '2'
},
{
    id: '5',
    name: 'Установка окон',
    start: '2020-04-04T00:00:00',
    progress: 0,
    end: '2020-04-10T00:00:00',
    dependencies: '3'
},


{
    id: '4',
    name: 'Установка крыши',
    start: '2020-04-10T00:00:00',
    progress: 0,
    end: '2020-04-15T00:00:00',
    dependencies: '5'
}];
var tasks2 = [{
    id: '1',
    name: 'Строительство дома',
    start: '2020-03-24T00:00:00',
    progress: 0,
    end: '2020-04-15T00:00:00',
    dependencies: ''
},
{
    id: '2',
    name: 'Установка фундамента',
    start: '2020-03-24T00:00:00',
    progress: 0,
    end: '2020-03-30T00:00:00',
    dependencies: '1'
},
{
    id: '3',
    name: 'Установка стен',
    start: '2020-03-30T00:00:00',
    progress: 50,
    end: '2020-04-10T00:00:00',
    dependencies: '1'
},
{
    id: '5',
    name: 'Установка окон',
    start: '2020-04-04T00:00:00',
    progress: 0,
    end: '2020-04-10T00:00:00',
    dependencies: '3'
},
{
    id: '4',
    name: 'Установка крыши',
    start: '2020-04-10T00:00:00',
    progress: 0,
    end: '2020-04-15T00:00:00',
    dependencies: '1'
}];
// let tasks = [

//     {
//         id: "1f71c2de-0a45-40a5-99ca-276366d11859",
//         name: "90453...",
//         start: "2020-03-05T00:00:00",
//         end: "2020-04-01T00:00:00",
//         progress: 1,
//         progress_min: 0,
//         dependencies: "",
//         price_earlier: 29,
//         price_late: 42,
//         price_durationc_changed: 29,
//         stage_id: "cb45823b-a9ca-4943-a589-e83d73382b0b",
//         project_id: null
//     },
//     {
//         id: "eae24c3e-b087-4c0c-a618-402245c1bfe4",
//         name: "dbb82...",
//         start: "2020-11-13T00:00:00",
//         end: "2020-12-20T00:00:00",
//         progress: 8,
//         progress_min: 4,
//         dependencies: "",
//         price_earlier: 13,
//         price_late: 34,
//         price_durationc_changed: 31,
//         stage_id: "7082b242-1b75-4c00-9a5f-6eddddac66ba",
//         project_id: null
//     },
//     {
//         id: "eb164ad5-c07f-4f0e-bdb9-5d39dc55049b",
//         name: "16322...",
//         start: "2020-10-13T00:00:00",
//         end: "2020-11-01T00:00:00",
//         progress: 28,
//         progress_min: 1,
//         dependencies: "",
//         price_earlier: 43,
//         price_late: 24,
//         price_durationc_changed: 8,
//         stage_id: "7082b242-1b75-4c00-9a5f-6eddddac66ba",
//         project_id: null
//     },
//     {
//         id: "bcf25e70-6d2b-4006-89a7-a1f17903bfed",
//         name: "0185f...",
//         start: "2020-03-19T00:00:00",
//         end: "2020-05-09T00:00:00",
//         progress: 24,
//         progress_min: 14,
//         dependencies: "",
//         price_earlier: 47,
//         price_late: 27,
//         price_durationc_changed: 29,
//         stage_id: "7082b242-1b75-4c00-9a5f-6eddddac66ba",
//         project_id: null
//     },
//     {
//         id: "967e1e97-6bb4-481f-896a-fc2c15544b59",
//         name: "86d9d...",
//         start: "2020-01-16T00:00:00",
//         end: "2020-03-26T00:00:00",
//         progress: 25,
//         progress_min: 23,
//         dependencies: "",
//         price_earlier: 26,
//         price_late: 25,
//         price_durationc_changed: 18,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     },
//     {
//         id: "89b0f714-fee9-475c-b576-5afb8bb66ee2",
//         name: "ba39f...",
//         start: "2020-11-25T00:00:00",
//         end: "0001-11-30T00:00:00",
//         progress: 3,
//         progress_min: 2,
//         dependencies: "",
//         price_earlier: 13,
//         price_late: 38,
//         price_durationc_changed: 7,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     },
//     {
//         id: "35a71ffb-8ef6-42ce-b0fa-dc54d6d0f7f3",
//         name: "bde26...",
//         start: "2020-02-19T00:00:00",
//         end: "2020-04-09T00:00:00",
//         progress: 15,
//         progress_min: 10,
//         dependencies: "",
//         price_earlier: 26,
//         price_late: 0,
//         price_durationc_changed: 2,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     },
//     {
//         id: "decb67bd-4f44-459f-abac-cd42c117a7da",
//         name: "c63db...",
//         start: "2020-09-05T00:00:00",
//         end: "2020-12-08T00:00:00",
//         progress: 27,
//         progress_min: 23,
//         dependencies: "",
//         price_earlier: 19,
//         price_late: 16,
//         price_durationc_changed: 0,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     },
//     {
//         id: "6a950141-23ee-487b-ba37-045a686241aa",
//         name: "72108...",
//         start: "2020-02-10T00:00:00",
//         end: "2020-04-13T00:00:00",
//         progress: 21,
//         progress_min: 17,
//         dependencies: "",
//         price_earlier: 28,
//         price_late: 1,
//         price_durationc_changed: 42,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     },
//     {
//         id: "c467727b-ff4c-4f83-8c51-f361397361cf",
//         name: "0edff...",
//         start: "2020-03-27T00:00:00",
//         end: "2020-05-29T00:00:00",
//         progress: 28,
//         progress_min: 1,
//         dependencies: "",
//         price_earlier: 10,
//         price_late: 38,
//         price_durationc_changed: 18,
//         stage_id: "5176d55c-de83-4b33-bb0b-b0b2dabae8a8",
//         project_id: null
//     }
// ]


var this_tasks = tasks1;

var gantt = new Gantt('#gantt', this_tasks, {
    language: "ru",
    on_click: function (task) {
    },
    on_date_change: function (task, start, end) {
        task.start = start;
        task.end = end;
        gantt.refresh(this_tasks);
    },
    on_progress_change: function (task, progress) {
        task.progress = progress;
        gantt.refresh(this_tasks);
    },
    on_view_change: function (mode) {
    }
});


gantt.change_view_mode('Day');


function initSelect(id) {
    // M.FormSelect.init(task_edit_select, {});
    var select = document.getElementById(id);
    
    while (select.firstChild) {
        console.log(select.firstChild)
        select.removeChild(select.firstChild);
    }
    // for (var i = 0, i = select.length; ++i) {
    //     li[i].onclick = function () {
    //         console.log('parentNode', this.parentNode);
    //         console.log('element => this', this);
    //         this.parentNode.removeChild(this);
    //     }
    // }
    // select.innerHTML = "";
    for (index = 0; index < this_tasks.length; ++index) {
        var option = document.createElement("option");
        option.value = index;
        var text = document.createTextNode(this_tasks[index].name);
        option.appendChild(text);
        select.appendChild(option);
    }

    return select
}

// EDIT TASK
var task_edit_select = initSelect("task-edit-select");
document.addEventListener('DOMContentLoaded', function () {
    M.FormSelect.init(task_edit_select, {});
});

// var task_edit_select = document.getElementById("task-edit-select");
var index_edit_select = task_edit_select.selectedIndex;
var name_edit = document.getElementById("name-edit");
name_edit.setAttribute("value", this_tasks[index_edit_select].name);
var end_edit_date = document.getElementById("end-edit-date");
end_edit_date.setAttribute("value", this_tasks[index_edit_select].end);
var progress_edit = document.getElementById("progress-edit");
progress_edit.setAttribute("value", this_tasks[index_edit_select].progress);

function changeOption() {
    index_edit_select = task_edit_select.selectedIndex;
    name_edit.value = this_tasks[index_edit_select].name;
    end_edit_date.value = this_tasks[index_edit_select].end;
    progress_edit.value = this_tasks[index_edit_select].progress;
}

task_edit_select.addEventListener("change", changeOption);

// ADD TASK

var task_add_select = initSelect("task-add-select");

document.addEventListener('DOMContentLoaded', function () {
    M.FormSelect.init(task_add_select, {});
});


var visible_select = document.getElementById("visible-select");
document.addEventListener('DOMContentLoaded', function () {
    M.FormSelect.init(visible_select, {});

});

visible_select.addEventListener("change", function () {
    gantt.change_view_mode(visible_select.selectedOptions[0].value);
});


// var result_select = document.getElementById("result-select");
// document.addEventListener('DOMContentLoaded', function () {
//     M.FormSelect.init(result_select, {});

// });

// result_select.addEventListener("change", function () {
//     switch (result_select.selectedOptions[0].value) {
//         case "1":
//             this_tasks = tasks1;
//             break;
//         case "2":
//             this_tasks = tasks2;
//             break;
//         case "3":
//             this_tasks = tasks3;
//             break;
//         default:
//             break;
//     }
//     gantt.refresh(this_tasks);
//     // gantt.change_view_mode(result_select.selectedOptions[0].value);
// });


var index_add_select = task_add_select.selectedIndex;
var name_add = document.getElementById("name-add");
var start_add_date = document.getElementById("start-add-date");
var end_add_date = document.getElementById("end-add-date");
var progress_add = document.getElementById("progress-add");

function createTask(s, e, d) {
    return {
        start: new Date(s),
        end: new Date(e),
        name: name_add.value,
        id: String(tasks.length + 1),
        progress: 0,
        dependencies: d
    };
}



document.getElementById("closeModal").onclick = function () {

    var selected_options = task_add_select.selectedOptions;
    if (selected_options.length > 0) {
        var dependencies = "";
        for (var i = 0; i < selected_options.length; i++) {
            dependencies = dependencies + this_tasks[selected_options[i].value].id + ",";
        }
        this_tasks.push(createTask(start_add_date.value, end_add_date.value, dependencies));
    }

    this_tasks[index_edit_select].name = name_edit.value;
    this_tasks[index_edit_select].end = new Date(end_edit_date.value);
    this_tasks[index_edit_select].progress = progress_edit.value;
    gantt.refresh(this_tasks);
    task_edit_select = initSelect("task-edit-select");
    task_add_select = initSelect("task-add-select")
}

document.getElementById("parse").onclick = function(){
    this_tasks = JSON.parse(document.getElementById("json-edit").value);
    gantt.refresh(this_tasks);
}

var option_picker = {
    autoClose: true,
    format: "yyyy-mm-dd"
}

document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll("#start-add-date");
    M.Datepicker.init(elems, option_picker);
});

document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll("#end-add-date");
    M.Datepicker.init(elems, option_picker);
});

document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll("#end-edit-date");
    M.Datepicker.init(elems, option_picker);
});

document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.modal');
    M.Modal.init(elems, {});
});

var el = document.querySelectorAll('.tabs')
var instance = M.Tabs.init(el);