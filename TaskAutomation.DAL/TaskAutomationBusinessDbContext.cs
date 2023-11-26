using Microsoft.EntityFrameworkCore;
using TaskAutomation.Domain;
using Action = TaskAutomation.Domain.Action;

namespace TaskAutomation.DAL;

public class TaskAutomationBusinessDbContext : DbContext
{
    public TaskAutomationBusinessDbContext(DbContextOptions<TaskAutomationBusinessDbContext> options) : base(options) {}

    public DbSet<Template>? Templates { get; set; }
    public DbSet<Action>? TemplateTasks { get; set; }
    public DbSet<ActionInputAttribute>? InputAttributes { get; set; }
    public DbSet<ActionQuestionAttribute>? QuestionAttributes { get; set; }
    public DbSet<ActionSimpleAttribute>? SimpleAttributes { get; set; }
    public DbSet<ActivationCondition>? ActivationConditions { get; set; }
    public DbSet<ActionStatus>? Statuses { get; set; }
    public DbSet<TemplateAnswer>? TemplateAnswers { get; set; }
    public DbSet<TemplatePoint>? TemplatePoints { get; set; }
    public DbSet<InputAttributeValue>? InputAttributeValue { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}