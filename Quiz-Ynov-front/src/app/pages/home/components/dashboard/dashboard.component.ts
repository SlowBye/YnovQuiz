import { Component, OnDestroy, OnInit } from '@angular/core';
import { Quiz } from '../../../../Business/models/quiz';
import { Subscription } from 'rxjs';
import { QuizService } from '../../../../Business/services/quizService';
import { RouterLink } from '@angular/router';
import { QuestionService } from '../../../../Business/services/questionService';
import { CategoryService } from '../../../../Business/services/categoryService';

import { Question } from '../../../../Business/models/question';
import { Category } from '../../../../Business/models/category';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent implements OnInit, OnDestroy{

  protected quizes: Quiz[]=[];
  protected questions: Question[]=[]; 
  protected categorys: Category[]=[];
  private subscription ?: Subscription; 
  constructor(private readonly quizService: QuizService, private readonly questionService : QuestionService, private readonly categoryService: CategoryService) { }

  ngOnInit(): void {
    this.quizService.list().subscribe(quizes => {
      this.quizes = quizes;
    });
    this.questionService.list().subscribe(questions => {
      this.questions = questions; 
    }); 
    this.categoryService.listCategory().subscribe(categorys=> {
      this.categorys= categorys; 
    }
    )
    
  }
  ngOnDestroy(): void {
         this.subscription?.unsubscribe
  }
  

}
